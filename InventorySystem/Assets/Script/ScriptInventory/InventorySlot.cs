using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image iconeS;
    public Button removeBtn;
    public Item item;

    public void AddItem(Item i)
    {
        item = i;
        iconeS.sprite = item.icone;
        iconeS.enabled = true;
        removeBtn.interactable = true;
    }

    public void ClearSlot()
    {
        item = null;
        iconeS.sprite = null;
        iconeS.enabled = false;
        removeBtn.interactable = false;
    }

    public void CallRemoveBtn()
    {
        InventoryCod.instance.RemoveI(item);
    }

    public void UseItem()
    {
        if(item != null)
        {
            item.Use();
            if(item.id ==0 && PlayerMoviment.inst.hp <100)
            {
                PlayerMoviment.inst.hp += 10;
                Debug.Log("Hp: "+PlayerMoviment.inst.hp);
            }
            else if (item.id == 1)
            {
                PlayerMoviment.inst.hp = 100;
                Debug.Log("Hp: " + PlayerMoviment.inst.hp);

            }
            InventoryCod.instance.RemoveI(item, true);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        iconeS = transform.GetChild(1).GetComponent<Image>();
        removeBtn = transform.GetChild(0).GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
