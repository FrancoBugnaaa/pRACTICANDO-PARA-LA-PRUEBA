using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej11 : MonoBehaviour
{
    public string anio;
    public string mes;
    public string dia;
    public string comprador;
    public string producto;
    public int cantidad;
    public float precioXu;
   float total;
    // Start is called before the first frame update
    void Start()
    {
        total = cantidad * precioXu;
        Debug.Log("Fecha de Compra " + anio + "/" + mes + "/" + dia);
        Debug.Log("Nombre Comprador " + comprador);
        Debug.Log("Producto solicitado " + producto);
        Debug.Log("Cantidad Solicitada " + cantidad);
        Debug.Log("Precio por Unidad $ " + precioXu);
        Debug.Log("Total a Pagar " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
