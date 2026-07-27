using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class InventorySlot : MonoBehaviour
{
    public Image iconeS;
    public Button removeBtn;
    public TMP_Text amountText;

    //public Item item;
    public InventoryItem item;

    public void AddItem(InventoryItem i)
    {
        item = i;
        iconeS.sprite = item.item.icone;
        iconeS.enabled = true;
        removeBtn.interactable = true;

        UpdateAmount();
    }

    public void ClearSlot()
    {
        item = null;
        iconeS.sprite = null;
        iconeS.enabled = false;
        amountText.enabled = false;
        removeBtn.interactable = false;
    }

    public void CallRemoveBtn()
    {
        InventoryCod.instance.RemoveI(item);
    }

    public void UseItem()
    {
        if (item != null)
        {
            // item.item.Use();
            InventoryCod.instance.UseItem(item);

        }
    }
    void UpdateAmount()
    {
        if (item.amount > 1)
        {
            amountText.text = item.amount.ToString();
            amountText.enabled = true;
        }
        else
        {
            amountText.enabled = false;
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
