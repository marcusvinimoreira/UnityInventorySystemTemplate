using UnityEngine;

[CreateAssetMenu(fileName = "HealItem", menuName = "Inventory/Items/Heal Item")]
public class HealItem : Item
{
    public int healAmount;

    public override void Use()
    {
        PlayerStats.inst.Heal(healAmount);
       // RemoveIUsing();
    }
}