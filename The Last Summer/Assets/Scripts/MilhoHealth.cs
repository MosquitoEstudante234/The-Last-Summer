using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class MilhoHealth : MonoBehaviour
{
    public float MilhoVida = 2;

    void Update()
    {
        if (MilhoVida <= 0)
        {
           Destroy(gameObject);
            FindObjectOfType<Score>().score += 20;
        }
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
       if (col.CompareTag("bullet"))
        {
            MilhoVida--;
            FindObjectOfType<AudioManager>().Play("MilhoHit");
        }
    }

}
