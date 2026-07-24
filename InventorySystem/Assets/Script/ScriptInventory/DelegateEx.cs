using UnityEngine;

public class Exemplo : MonoBehaviour
{
    public delegate void ExemploDelegate(string s);
    public ExemploDelegate variavel;
    public int controle = 0;
    public void OlaDelegate()
    {
        print("Oi Delegate");
    }
    public void OlaDelegate2(string s)
    {
        print(s);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //if(controle==1)
        //{
        //    variavel = OlaDelegate;
        //}
        //else
        //{
        //    variavel = OlaDelegate2;
        //}
        variavel = OlaDelegate2;
        variavel("Oi Delegate2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
