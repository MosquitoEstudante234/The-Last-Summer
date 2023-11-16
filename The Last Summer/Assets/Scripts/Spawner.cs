using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Obstaculo;
    public float timeBetweenSpawn = 5f;
    private float spawnTime = 0;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;



    }
    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }
    void Spawn()
    {
        Instantiate(Obstaculo, transform.position, transform.rotation);
    }
}
