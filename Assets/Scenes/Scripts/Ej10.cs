using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej10 : MonoBehaviour
{
    public const int horaapertura = 10;
    public const int horacierre = 18;
    public int HoraActual;
    public bool estaAbierto;
    // Start is called before the first frame update
    void Start()
    {
        if(HoraActual > 24 || HoraActual < 0) { Debug.Log("Igresasste un horario erroneo"); }
        if(HoraActual < horaapertura || HoraActual > horacierre)
        {
            estaAbierto = false;
            Debug.Log("estacionamiento abierto " + estaAbierto);
        }
        else
        {
            estaAbierto = true;
            Debug.Log("estacionamiento abierto" + estaAbierto);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
