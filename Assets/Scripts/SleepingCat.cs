using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepingCat : MonoBehaviour {

    public int dayToAppear;
    private void Start()
    {
        GameObject tracker = GameObject.FindGameObjectWithTag("Track");
        if(tracker.GetComponent<Track>().day != dayToAppear || 
            (tracker.GetComponent<Track>().lastDayReady == false && tracker.GetComponent<Track>().day == 11 ))
        {
            this.gameObject.SetActive(false);
        }
    }
}
