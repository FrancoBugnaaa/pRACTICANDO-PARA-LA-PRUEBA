using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej08 : MonoBehaviour
{
    public int dia;
    // Start is called before the first frame update
    void Start()
    {switch (dia)
        {
            case 1:
                Debug.Log("Hoy es Domingo");
                break;
            case 2:
                Debug.Log("Hoy es Lunes");
                break;
            case 3:
                Debug.Log("Hoy es Martes");
                break;
            case 4:
                Debug.Log("Hoy es Miercoles");
                break;
            case 5:
                Debug.Log("Hoy es Jueves");
                break;
            case 6:
                Debug.Log("Hoy es Viernes");
                break;
            case 7:
                Debug.Log("Hoy es Sabado");
                break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
