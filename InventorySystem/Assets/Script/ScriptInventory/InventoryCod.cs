using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryCod : MonoBehaviour
{
    public static InventoryCod instance;

    public GameObject player;
    public GameObject[] objetoCol;

    void Awake()
    {
        if(instance== null)
        {
            instance = this;
            player = GameObject.FindGameObjectWithTag("Player");
        }
    }

    public delegate void ChangeItem();
    public event ChangeItem ChangeItemE;
    [SerializeField]
    private int numberSlots;
    public List<Item> items = new List<Item>();

    public bool AddItem(Item i)
    {
        if(items.Count >= numberSlots)
        {
            print("Não tem mais lugar ");
            return false;
        }
        items.Add(i);
        if(ChangeItemE != null)
        {
            ChangeItemE();
        }
        return true;
    }
    public void RemoveI(Item i)
    {
        items.Remove(i);
        Instantiate(objetoCol[i.id], new Vector2(player.transform.position.x, player.transform.position.y), Quaternion.identity);

        if (ChangeItemE != null)
        {
            ChangeItemE();
        }
    }

    public void RemoveI(Item i, bool used)
    {
        if(used)
        {
            items.Remove(i);
            if(ChangeItemE !=null)
            {
                ChangeItemE();
            }
        }
    }
   
}
