﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej06 : MonoBehaviour
{
    public int num1;
    // Start is called before the first frame update
    void Start()
    {if (num1 / 2 == 0)
        {
            Debug.Log("Es impar");
        }
    else if (num1 / 2 != 0)
        {
            Debug.Log("Es par");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
