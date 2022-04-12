//Se pide que se ingrese por inspector:
//. Los nombre de tres productos
//.Los precios de cada producto
//.La cantidad de unidades deseada de cada producto

//El programa debe cumplir los siguientes requerimientos:

//Debe calcularse un descuento del 20% sobre la compra de un producto si la cantidad de unidades del mismo supera las 3. 

//El programa debe devolver un mensaje de error descriptivo si el precio del producto o la cantidad de unidades son menores a 1.

//El programa debe devolver el total de la compra de los tres productos mostrando un mensaje que incluya el monto total sin
//descuento, el monto de los descuentos aplicados y el total con los descuentos aplicados.


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej01 : MonoBehaviour
{
    public float precio1, precio2, precio3;
    public int cant1, cant2, cant3;
    float desc1, desc2, desc3, total1, total2, total3, total;
    

    void Start()
    {
        if (precio1 < 1 || precio2 < 1 || precio3 < 1 || cant1 < 1 || cant2 < 1 || cant3 < 1)
        {
            Debug.Log("Error descriptivo, ningun valor puede ser 0");
        }

        else
        {
            total1 = precio1 * cant1;
            total2 = precio2 * cant2;
            total3 = precio3 * cant3;
            total = precio1 * cant1 + precio2 * cant2 + precio3 * cant3;

            if (cant1 > 3)
            {
               
                desc1 = (total1) * 0.2f;
                
                

                Debug.Log("Monto total sin descuento: " + total + ", El descuento de 20% te restan unos $" + desc1 + ", El total con descuento aplicado es de $" + (total-desc1));
            }

            else if (cant2 > 3)
            {
              
                desc2 = (total2) * 0.2f;
                


                Debug.Log("Monto total sin descuento: " + total + ", El descuento de 20% te restan unos $" + desc2 + ", El total con descuento aplicado es de $" + (total - desc2));
            }

            else if (cant3 > 3)
            {
                
                desc3 = (total3) * 0.2f;



                Debug.Log("Monto total sin descuento: " + total + ", El descuento de 20% te restan unos $" + desc3 + ", El total con descuento aplicado es de $" + (total - desc3));
            }
            else if (cant1 > 3 && cant2 > 3)
            {
                desc1 = (total1) * 0.2f;
                desc2 = (total2) * 0.2f;


                Debug.Log("Monto total sin descuento: " + total + ", El descuento de 20% te restan unos $" + (desc1 + desc2) + ", El total con descuento aplicado es de $" + (total - desc1 - desc2));
            }

            else if (cant2 > 3 && cant3 > 3)
            {
                desc3 = (total3) * 0.2f;
                desc2 = (total2) * 0.2f;


                Debug.Log("Monto total sin descuento: " + total + ", El descuento de 20% te restan unos $" + (desc2 + desc3) + ", El total con descuento aplicado es de $" + (total - desc3 - desc2));
            }

            else if (cant1 > 3 && cant3 >3)
            {
                desc1 = (total1) * 0.2f;
                desc3 = (total3) * 0.2f;


                Debug.Log("Monto total sin descuento: " + total + ", El descuento de 20% te restan unos $" + (desc1 + desc3) + ", El total con descuento aplicado es de $" + (total - desc1 - desc2));
            }

            else if (cant1 > 3 && cant2 > 3 && cant3 > 3)
            {
                desc1 = (total1) * 0.2f;
                desc2 = (total2) * 0.2f;
                desc3 = (total3) * 0.2f;


                Debug.Log("Monto total sin descuento: " + total + ", El descuento de 20% te restan unos $" + (desc1 + desc2 + desc3) + ", El total con descuento aplicado es de $" + (total - desc1 - desc2 - desc3));
            }
        }
    }

    
    void Update()
    {
        
    }
}
