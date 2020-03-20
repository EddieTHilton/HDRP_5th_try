using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{

    private GameObject FadeToBlack;
    public bool completed = false;
    private bool fading = false;
    
    // Start is called before the first frame update
    void Start()
    {
        FadeToBlack = GameObject.Find("FadeToBlack");
        fading = FadeToBlack.GetComponent<Fading>().fading;
    }

    public void OnTriggerStay(Collider collision)
    {
        if (fading == false && completed == true)
        {
            fading = true;
            FadeToBlack.GetComponent<Fading>().fading = fading;
        }
    }

}
