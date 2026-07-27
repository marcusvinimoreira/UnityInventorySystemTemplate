using UnityEngine;

[System.Serializable]
public class InventoryItem
{
    public Item item;
    public int amount;

    public InventoryItem(Item item)
    {
        this.item = item;
        amount = 1;
    }
   
}