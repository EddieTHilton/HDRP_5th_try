using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public string SceneToLoad;

    public void SceneLoader()
    {
        SceneManager.LoadScene(SceneToLoad);
        Debug.Log("Loaded" + SceneToLoad);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QuitGame");
    }
}
