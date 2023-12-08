using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFade : MonoBehaviour
{
    public GameObject Fade;
    public void DestroyFadeGamer()
    {
        Destroy(Fade);
    }

}
