using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej14 : MonoBehaviour
{
    public float num1;
    public float num2;
    public string operaciones;
    float s;
    float r;
    float p;
    float d;
    // Start is called before the first frame update
    void Start()
    {
        s = num1 + num2;
        r = num1 - num2;
        p = num1 * num2;
        d = num1 / num2;
        switch (operaciones)
        {
            case "s":
                Debug.Log(s);
                break;
            case "r":
                Debug.Log(r);
                break;
            case "p":
                Debug.Log(p);
                break;
            case "d":
                Debug.Log(d);
                break;
            default:
                Debug.Log("No es una operacion valida");
                break;

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
