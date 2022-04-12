using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej15 : MonoBehaviour
{
    public int num1;
    bool estaEnA = false;
    bool estaEnB = false;
    bool estaEnAmbos = false;
    bool noEstaEnNinguno = false;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 %2 != 0)
        {
            estaEnB = true;
        } //else
        //{
//            estaEnB = false;
  //      }
        if (num1 < 10)
        {
            estaEnA = true;
        }
        if(estaEnA==true && estaEnB == true)
        {
            estaEnAmbos= true;
        }
        if (estaEnA == false && estaEnB == false)
        {
            noEstaEnNinguno = true;
        }
        Debug.Log("Esta en A: " + estaEnA);
        Debug.Log("Esta en B: " + estaEnB);
        Debug.Log("Esta en Ambos: " + estaEnAmbos);
        Debug.Log("Esta en No esta en Ninguno: " + noEstaEnNinguno);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
