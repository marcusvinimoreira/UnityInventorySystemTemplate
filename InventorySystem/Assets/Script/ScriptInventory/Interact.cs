using UnityEngine;
using System.Collections.Generic;


public class Interact : MonoBehaviour
{
    public float ray = 0.5f;
    public bool isFocus = false;
    public bool interacted = false;

    public virtual void InteractM()
    {
        Debug.Log("interagindo com " + transform.name);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(isFocus && !interacted)
        {
            Debug.Log("Chamando InteractM");

            InteractM();
            interacted = true;
        }
    }

    public void OnFocus()
    {
        isFocus = true;
        interacted = false;
    }

   
}
