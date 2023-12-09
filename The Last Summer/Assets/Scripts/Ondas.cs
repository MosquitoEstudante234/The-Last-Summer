using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ondas : MonoBehaviour
{
 
    public GameObject Spawner1, Spawner2, Spawner3, Spawner4, Spawner5, Spawner6, Spawner7, Spawner8, Spawner9, Objetivos, TextoOnda, FinalGame, Obfinal;
    public Text ondasTxt;
    public int ondas;
    private void Start()
    {

        ondas = 1;
        
    }


    private void Update()
    {
        ondasTxt.text = ondas.ToString();
     if (ondas == 2)
     {
    Spawner1.SetActive(true);
    Spawner2.SetActive(true);
    Spawner3.SetActive(true);
     }

      if (ondas == 3)
     {
    Spawner4.SetActive(true);
    Spawner5.SetActive(true);
     }
      if (ondas == 4)
     {
    Spawner6.SetActive(true);
     }
     if (ondas == 5)
     {
    Spawner7.SetActive(true);
    Spawner8.SetActive(true);
    Spawner9.SetActive(true);
     }
     if (ondas == 6)
     {
    Spawner1.SetActive(false);
    Spawner2.SetActive(false);
    Spawner3.SetActive(false);
    Spawner4.SetActive(false);
    Spawner5.SetActive(false);
    Spawner6.SetActive(false);
    Spawner7.SetActive(false);
    Spawner8.SetActive(false);
    Spawner9.SetActive(false);
     }
     if (FindObjectOfType<Score>().score >= 120)
     {
      ondas = 2;
     }
     if (FindObjectOfType<Score>().score >= 240)
     {
      ondas = 3;
     }
     if (FindObjectOfType<Score>().score >= 400)
     {
      ondas = 4;
     }
     if (FindObjectOfType<Score>().score >= 520)
     {
      ondas = 5;
     }
      if (FindObjectOfType<Score>().score >= 800)
     {
      ondas = 6;
      Objetivos.SetActive(false);
      TextoOnda.SetActive(false);
      FinalGame.SetActive(true);
      Obfinal.SetActive(true);
     }
    }


}
