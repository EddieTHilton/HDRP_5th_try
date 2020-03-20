using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Fading : MonoBehaviour
{
    public bool fading = false;
    private float alpha = 0;
    private byte alphaByte;
    public float fadeSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        fadeSpeed = fadeSpeed / 100;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (fading == true) {
            alpha = alpha + fadeSpeed;
            alphaByte = Convert.ToByte(alpha);
            this.GetComponent<Image>().color = new Color32(0, 0, 0, alphaByte);
            if (alpha >= 255)
            {
                fading = false;
                this.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
                SceneManager.LoadScene("Credits");
            }

        }
    }
}
