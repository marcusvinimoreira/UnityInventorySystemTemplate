using UnityEngine;
using System.Collections.Generic;
using System.Collections;

[RequireComponent(typeof(CircleCollider2D))]
public class GetItem : Interact
{
    public Item item;
    public CircleCollider2D col;
    public bool caught;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        col = GetComponent<CircleCollider2D>();
        col.radius = ray;
        col.isTrigger = true;
        gameObject.tag = "Item";
    }

    public override void InteractM()
    {
        base.InteractM();
        Collect();
    }
    void Collect()
    {
        Debug.Log("Pegando" + item.name);
        caught = InventoryCod.instance.AddItem(item);
        if(caught)
        {
            Destroy(gameObject);
        }
    }
   
}
