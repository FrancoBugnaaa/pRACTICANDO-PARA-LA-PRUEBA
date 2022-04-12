using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej09 : MonoBehaviour
{
    public string persona1;
    public string persona2;
    public string persona3;
    public float capaport1;
    public float capaport2;
    public float capaport3;
    float porcentaje1;
    float porcentaje2;
    float porcentaje3;
    float montototal;

    // Start is called before the first frame update
    void Start()
    {
        montototal = capaport1 + capaport2 + capaport3;
        porcentaje1 = capaport1 * 100 / montototal;
        porcentaje2 = capaport2 * 100 / montototal;
        porcentaje3 = capaport3 * 100 / montototal;
        Debug.Log(persona1 + " aporto $" + capaport1 + " representa el %" + porcentaje1 + " del total " + "el total es " + montototal);
        Debug.Log(persona2 + " aporto $" + capaport2 + " representa el %" + porcentaje2 + " del total " + "el total es " + montototal);
        Debug.Log(persona3 + " aporto $" + capaport3 + " representa el %" + porcentaje3 + " del total " + "el total es " + montototal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
