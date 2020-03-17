using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Major_Event_Growable : MonoBehaviour
{
    public GameObject c_thischild;
    private bool activated = false;
    private bool completed = false;

    private GameObject EventTracker;
    private GameObject PauseHandler;


    public void Start()
    {
        //Assigns the transform of the first child of the Game Object this script is attached to.
        c_thischild = this.gameObject.transform.GetChild(0).gameObject;

        EventTracker = GameObject.Find("Event Tracker");
        EventTracker.GetComponent<EventTrackerScript>().majorEventsTotal++;

        PauseHandler = GameObject.Find("PauseHandler");
    }
    

    public void OnTriggerStay(Collider collision)
    {

        if (collision.gameObject.tag == "Player" && activated == false) //PlayerReach, is the range within which the player-character can touch surrounding objects
        {
            PauseHandler.GetComponent<Pause_Handler>().isGamePaused = true;
            if (PauseHandler.GetComponent<Pause_Handler>().isMinigameRunning != true)
            {
                PauseHandler.GetComponent<Pause_Handler>().StartMinigame();
            }
            PauseHandler.GetComponent<Pause_Handler>().isMinigameRunning = true;
            activated = true;
        }

        if (collision.gameObject.tag == "MajorReach" && completed == false) //PlayerReach, is the range within which the player-character can touch surrounding objects
        {
            c_thischild.SetActive(true);
            completed = true;

            EventTracker.GetComponent<EventTrackerScript>().majorEventsActive++;
        }
    }
}
