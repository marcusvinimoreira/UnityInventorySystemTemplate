using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryCod : MonoBehaviour
{
    public static InventoryCod instance;

    public GameObject player;

    public delegate void ChangeItem();
    public event ChangeItem ChangeItemE;
    [SerializeField]
    private int numberSlots;
    // public List<Item> items = new List<Item>();
    public List<InventoryItem> items = new List<InventoryItem>();

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            player = GameObject.FindGameObjectWithTag("Player");
        }
    }


    public bool AddItem(Item i, int amount = 1)
    {
        // Procura se o item já existe no inventário
        for (int index = 0; index < items.Count; index++)
        {
            if (items[index].item == i)
            {
                items[index].amount+=amount;

                if (ChangeItemE != null)
                {
                    ChangeItemE();
                }

                return true;
            }
        }

        if (items.Count >= numberSlots)
        {
            print("Não tem mais lugar ");
            return false;
        }
        InventoryItem newItem = new InventoryItem(i);
        newItem.amount = amount;
        items.Add(newItem);
        if (ChangeItemE != null)
        {
            ChangeItemE();
        }
        return true;
    }

    //public void RemoveI(Item i)
    //{
    //    items.Remove(i);
    //    Instantiate(objetoCol[i.id], new Vector2(player.transform.position.x, player.transform.position.y), Quaternion.identity);

    //    if (ChangeItemE != null)
    //    {
    //        ChangeItemE();
    //    }
    //}

    //public void RemoveI(Item i, bool used)
    //{
    //    if(!used)
    //    {
    //        return;
    //    }

    //    if(used)
    //    {
    //        items.Remove(i);
    //        if(ChangeItemE !=null)
    //        {
    //            ChangeItemE();
    //        }
    //    }
    //}

    public void UseItem(InventoryItem inventoryItem)
    {

        inventoryItem.item.Use();

        inventoryItem.amount--;

        if (inventoryItem.amount <= 0)
        {
            items.Remove(inventoryItem);


        }

        if (ChangeItemE != null)
        {
            ChangeItemE();
        }
    }
    public void RemoveI(InventoryItem inventoryItem)
    {
        GameObject obj = Instantiate(inventoryItem.item.dropPrefab, player.transform.position, Quaternion.identity);
        items.Remove(inventoryItem);
        // Pega o script GetItem do objeto criado
        GetItem getItem = obj.GetComponent<GetItem>();

        // Passa a quantidade para o objeto da cena
        getItem.amount = inventoryItem.amount;

        // Remove do inventário
        items.Remove(inventoryItem);
        items.Remove(inventoryItem);
        if (ChangeItemE != null)
        {
            ChangeItemE();
        }
    }

    public void RemoveI(Item i, bool used)
    {
        if (used)
        {
            for (int index = 0; index < items.Count; index++)
            {
                if (items[index].item == i)
                {
                    items.RemoveAt(index);
                    break;
                }
            }

            if (ChangeItemE != null)
            {
                ChangeItemE();
            }
        }
    }


}
