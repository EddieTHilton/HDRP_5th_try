using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventTrackerScript : MonoBehaviour
{
    public int majorEventsTotal = 0;
    public int majorEventsActive = 0;

    private GameObject MajorTracker;

    private void Start()
    {
        MajorTracker = GameObject.Find("Major Events");

    }

    private void Update()
    {
        MajorTracker.GetComponent<Text>().text = ("Major Events: \n" + majorEventsActive + " / " + majorEventsTotal);
    }

}
