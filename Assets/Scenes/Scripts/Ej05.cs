using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej05 : MonoBehaviour
{
    public int num1;
    public int num2;
    int resultado;
    
    // Start is called before the first frame update
    void Start()
    {
        if (num2 == 0)
        {
            Debug.Log("No se puede dividir por 0");
        }
        else if (num2 < 0)
        {
            Debug.Log("es divisible por " + num2);
        }
        resultado = num1 / num2;
        Debug.Log(num1 + " / " + num2 + " = " + resultado);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
