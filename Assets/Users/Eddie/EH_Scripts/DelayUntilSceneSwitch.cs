using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DelayUntilSceneSwitch : MonoBehaviour
{
    public float lifetime = 10.0f; // The length of time in seconds until the object is deactivated.

    // Update is called once per frame
    void Update()
    {
        if (lifetime <= 0)
        {
            SceneManager.LoadScene("StartScene");
        }

        lifetime = lifetime - Time.deltaTime;
    }
}
