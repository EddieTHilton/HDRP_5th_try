using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventTrackerScript : MonoBehaviour
{
    public int majorEventsTotal = 0;
    public int majorEventsActive = 0;

    public int minorEventsTotal = 0;
    public int minorEventsActive = 0;

    private GameObject MajorTracker;
    private GameObject MinorTracker;
    private GameObject EndCollider;

    private void Start()
    {
        MajorTracker = GameObject.Find("Major Events");
        MinorTracker = GameObject.Find("Minor Events");
        EndCollider = GameObject.Find("EndGameCollider");
    }

    private void Update()
    {
        MajorTracker.GetComponent<Text>().text = ("Major Events: \n" + majorEventsActive + " / " + majorEventsTotal);
        MinorTracker.GetComponent<Text>().text = ("Minor Events: \n" + minorEventsActive + " / " + minorEventsTotal);
        if (majorEventsActive >= majorEventsTotal)
        {
            EndCollider.GetComponent<Ending>().completed = true;
        }
    }

}
