using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MilhoHealth : MonoBehaviour
{
    public float MilhoVida = 2;

    void Update()
    {
        if (MilhoVida <= 0)
        {
           Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
       if (col.CompareTag("bullet"))
        {
            MilhoVida--;
        }
    }

}
