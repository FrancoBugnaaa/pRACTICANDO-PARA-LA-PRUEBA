using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej13 : MonoBehaviour
{
  const int salarionormal = 16;
    const int salariohorasextras = 20;
    public int horasTrabajadas;

    // Start is called before the first frame update
    void Start()
    {
     if(horasTrabajadas <= 40)
        {
            Debug.Log("Se le va a pagar $" + horasTrabajadas * salarionormal);
        }   
     else
        {
            horasTrabajadas -= 40;
            Debug.Log("Se le va a pagar $" + ((40 * 16) + (horasTrabajadas*20)));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
