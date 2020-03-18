using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EH_ActivateOnInteract : MonoBehaviour
{
    public GameObject c_thischild;
    private GameObject EventTracker;
    private bool completed = false;

    public void Start()
    {
        //Assigns the transform of the first child of the Game Object this script is attached to.
        c_thischild = this.gameObject.transform.GetChild(0).gameObject;


        EventTracker = GameObject.Find("Event Tracker");
        EventTracker.GetComponent<EventTrackerScript>().minorEventsTotal++;
    }

    public void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "PlayerReach" && Input.GetKey(KeyCode.E) && completed == false) //PlayerReach, is the range within which the player-character can touch surrounding objects
        {
            c_thischild.SetActive(true);

            EventTracker.GetComponent<EventTrackerScript>().minorEventsActive++;
            completed = true;
        }
    }
}
