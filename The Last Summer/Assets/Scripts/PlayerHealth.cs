using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
   public float health = 3;
    public GameObject Vidas1, Vidas2, Vidas3, Death;

    public void Start()
    {
       
    }
    void Update()
    {

        
        if (health == 0)
        {
            Death.SetActive(true);
            Time.timeScale = 0;
            health++;
        }
        if (health < 0)
        {
            health = 0;
        }
        print(health);

        if (health == 0)
        {
            Vidas1.SetActive(false);
            Vidas2.SetActive(false);
            Vidas3.SetActive(false);
            
        }
        if (health == 1)
        {
            Vidas1.SetActive(true);
            Vidas2.SetActive(false);
            Vidas3.SetActive(false);
           
        }
        if (health == 2)
        {
            Vidas1.SetActive(true);
            Vidas2.SetActive(true);
            Vidas3.SetActive(false);
            
        }
        if (health == 3)
        {
            Vidas1.SetActive(true);
            Vidas2.SetActive(true);
            Vidas3.SetActive(true);
            
        }
      
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("MilhoMira"))
        {
            health--;
        }
    }

}
