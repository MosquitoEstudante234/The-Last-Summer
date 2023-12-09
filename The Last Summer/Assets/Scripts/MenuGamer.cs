using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGamer : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("cena2");
    }
    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Saindo...");
    }

    public void ReplayButton()
    {
        Time.timeScale = 1;
    }
    public void Renascer()
    {
        SceneManager.LoadScene("cena1");
        Time.timeScale = 1;
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("cena0");
        Time.timeScale = 1;
    }
}
