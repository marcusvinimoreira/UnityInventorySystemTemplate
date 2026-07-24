using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName ="Items", menuName ="Inventory/Item")]
public class Item : ScriptableObject
{
    public string nameItem;
    public Sprite icone;
    public int id;

    public virtual void Use()
    {
        Debug.Log("Using "+nameItem);

    }

    public void RemoveIInv()
    {
        InventoryCod.instance.RemoveI(this);
    }
}
