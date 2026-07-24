using UnityEngine;
using System.Collections.Generic;

public class InventoryUI : MonoBehaviour
{
    public Transform bag;
    public GameObject inventoryUI;
    public InventorySlot[] slots;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       

        InventoryCod.instance.ChangeItemE +=UIMethod;
        slots = bag.GetComponentsInChildren<InventorySlot>();
    }
    void UIMethod()
    {
        for(int i = 0; i <slots.Length; i++)
        {
            if(i< InventoryCod.instance.items.Count)
            {
                slots[i].AddItem(InventoryCod.instance.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
