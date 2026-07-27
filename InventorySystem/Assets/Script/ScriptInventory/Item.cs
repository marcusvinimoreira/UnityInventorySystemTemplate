using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName ="Items", menuName ="Inventory/Item")]
public class Item : ScriptableObject
{
    public string nameItem;
    public Sprite icone;
    public int id;
    public GameObject dropPrefab;

    public virtual void Use()
    {
        Debug.Log("Using " + nameItem);

    }

   
}
