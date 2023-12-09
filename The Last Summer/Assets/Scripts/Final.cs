using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    public GameObject WinScreen, Obfinal2;


    public void OnTriggerEnter2D (Collider2D col)
    {
      if (col.CompareTag("Final") && FindObjectOfType<Ondas>().ondas == 6)
      {
        WinScreen.SetActive(true);
        Time.timeScale = 0f;
      }
      if (col.CompareTag("PortaCeleiro"))
      {
        Destroy(Obfinal2);
      }
    }
}
