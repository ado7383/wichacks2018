using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleCat : MonoBehaviour {
    public int[] daysToNotShow;
    private GameObject tracker;
	// Use this for initialization
	void Start ()
    {
        tracker = GameObject.FindGameObjectWithTag("Track");
        foreach (int i in daysToNotShow)
        {
            if(tracker.GetComponent<Track>().day == i)
            {
                //this.gameObject.SetActive(false);
                tracker.GetComponent<Track>().fed = true;
            }
        }
	}


}
