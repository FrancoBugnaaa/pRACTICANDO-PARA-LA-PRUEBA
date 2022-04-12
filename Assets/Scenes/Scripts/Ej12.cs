using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej12 : MonoBehaviour
{
    public int dado1;
    public int dado2;
    public int dado3;
    public int cantSeis;
    // Start is called before the first frame update
    void Start()
    {
        if(dado1 == 6)
        {
            cantSeis++ ;
        }
        if (dado2 == 6)
        {
            cantSeis++ ;
        }
        if (dado3 == 6)
        {
            cantSeis++ ;
        }
        switch (cantSeis)
        {
            case 0:
                Debug.Log("Insuficiente");
                break;
            case 1:
                Debug.Log("Regular");
                break;
            case 2:
                Debug.Log("Muy Bien");
                break;
            case 3:
                Debug.Log("Excelente");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
