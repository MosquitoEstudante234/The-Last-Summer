using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ativadores : MonoBehaviour
{
    public GameObject CaixaNormal;
    public GameObject Panfleto;
    public GameObject Cama;
    public GameObject Filho;
    public GameObject Diario;
    public GameObject Fade;
    public GameObject Objetivo;
  
  
   public void OnTriggerEnter2D(Collider2D col)
   {
     if (col.CompareTag("CaixaNormal"))
     {
        CaixaNormal.SetActive(true);
     }

      if (col.CompareTag("Panfleto"))
     {
        Panfleto.SetActive(true);
     }

      if (col.CompareTag("Cama"))
     {
        Cama.SetActive(true);
     }

      if (col.CompareTag("Filho"))
     {
        Filho.SetActive(true);
     }

      if (col.CompareTag("Diario"))
     {
        Diario.SetActive(true);
     }
     if (col.CompareTag("Faders"))
     {
        Fade.SetActive(true);
        Objetivo.SetActive(false);
     }
    
   }
    public void OnTriggerExit2D(Collider2D col)
    {

 if (col.CompareTag("CaixaNormal"))
     {
        CaixaNormal.SetActive(false);
     }

      if (col.CompareTag("Panfleto"))
     {
        Panfleto.SetActive(false);
     }

      if (col.CompareTag("Cama"))
     {
        Cama.SetActive(false);
     }

      if (col.CompareTag("Filho"))
     {
        Filho.SetActive(false);
     }

      if (col.CompareTag("Diario"))
     {
        Diario.SetActive(false);
     }


    }
   
    
}
