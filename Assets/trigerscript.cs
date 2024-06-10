using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class trigerscript : MonoBehaviour
{
    public Text text;
    public int puntaje = 0; 
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<pickUpSqript>())
        {
            pickUpSqript pickUpSqript = other.GetComponent<pickUpSqript>();
            if (pickUpSqript.escomida)
            {
                puntaje += pickUpSqript.valor;
                Destroy(other.gameObject);
            }
            else
            {
                puntaje += pickUpSqript.valor;
            }
            text.text = "puntaje: " + puntaje;
        }
    }
}
