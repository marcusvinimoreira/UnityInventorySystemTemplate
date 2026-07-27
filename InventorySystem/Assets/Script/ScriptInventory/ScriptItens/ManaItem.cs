using UnityEngine;

[CreateAssetMenu(fileName = "ManaItem", menuName = "Inventory/Items/Mana Item")]
public class ManaItem : Item
{
    [SerializeField]
    private int manaAmount;

    public override void Use()
    {
        PlayerStats.inst.RestoreMana(manaAmount);

      
    
    }
}