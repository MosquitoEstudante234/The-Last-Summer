using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaENoite : MonoBehaviour
{
    public GameObject Fade;
    public GameObject Camera;
    public GameObject Camera2;
    public GameObject Player;
    public GameObject Day;

  
    public void TrocarHoras ()
    {
       Camera.SetActive(false);
       Camera2.SetActive(true); 
       Player.transform.position = Day.transform.position;
    }

    public void DestroyMyFadePls()
    {
        Destroy(Fade);
    }

}
