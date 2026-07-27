using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats inst;

    [Header("Health")]
    [SerializeField] private int health = 100;
    [SerializeField] private int maxHealth = 100;
    [Header("Mana")]
    [SerializeField] private int mana = 100;
    [SerializeField] private int maxMana = 100;


    private void Awake()
    {
        inst = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Heal(int healAmount)
    {
        health = Mathf.Min(health + healAmount, maxHealth);
        Debug.Log($"HP: {health}/{maxHealth}");

    }

    public void RestoreMana(int manaAmount)
    {
        mana = Mathf.Min(mana + manaAmount, maxMana);
        Debug.Log($"Mana: {mana}/{maxMana}");
    }
}
