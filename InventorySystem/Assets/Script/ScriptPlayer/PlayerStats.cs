using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats inst;

    [Header("Health")]
    [SerializeField] private int health = 50;
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private TMP_Text currentHP; 
    [Header("Mana")]
    [SerializeField] private int mana = 30;
    [SerializeField] private int maxMana = 100;
    [SerializeField] private TMP_Text currentMana;



    private void Awake()
    {
        inst = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHP.text = health.ToString();
        currentMana.text = mana.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Heal(int healAmount)
    {
        health = Mathf.Min(health + healAmount, maxHealth);
        currentHP.text = health.ToString();
        Debug.Log($"HP: {health}/{maxHealth}");

    }

    public void RestoreMana(int manaAmount)
    {
        mana = Mathf.Min(mana + manaAmount, maxMana);
        currentMana.text = mana.ToString();
        Debug.Log($"Mana: {mana}/{maxMana}");
    }
}
