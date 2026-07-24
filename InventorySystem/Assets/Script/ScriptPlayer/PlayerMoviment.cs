using UnityEngine;
using System.Collections;


public class PlayerMoviment : MonoBehaviour
{
    public float moveX, moveY;
    public float speed = 3.5f;
    private Rigidbody2D rb;
    public int hp=10;

    public Interact focus;

    public static PlayerMoviment inst;

    private void Awake()
    {
        if(inst==null)
        {
            inst = this;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        rb.linearVelocity = new Vector2(moveX * speed, moveY * speed);
        Getitem();
    }

    void Getitem()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            if(focus != null)
            {
                

                focus.OnFocus();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            focus = collision.GetComponent<Interact>();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            focus = null;
        }
    }
}
