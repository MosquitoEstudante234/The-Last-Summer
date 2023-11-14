using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float spd = 20f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * spd;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Destroy(collision.gameObject);
        if (collision.CompareTag("Milho"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            
        }
        if (collision.CompareTag("Milhochorro"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            
        }
        if (collision.CompareTag("CowboyMilho"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Paredes"))
        {
            Destroy(gameObject);
        }

    }

    private void Update()
    {
        if (transform.position.x >= 20)
        {
            Destroy(gameObject);
        }
    }
}
