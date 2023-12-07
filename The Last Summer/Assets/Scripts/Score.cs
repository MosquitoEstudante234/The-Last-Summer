using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreTxt;
    public int score;
    private void Start()
    {

        score = 0;
        
    }


    private void Update()
    {
        scoreTxt.text = score.ToString();

    }
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.CompareTag("") == true)
        {
            score = score + 1;
            Destroy(col.gameObject);
        }
       
    }

}
