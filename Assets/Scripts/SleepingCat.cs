using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepingCat : MonoBehaviour {

    public int dayToAppear;
    private bool gameEnd;
    private int count;
    private GameObject tracker;

    private void Start()
    {
        gameEnd = false;
        count = 0;
        tracker = GameObject.FindGameObjectWithTag("Track");
        if(tracker.GetComponent<Track>().day != dayToAppear || 
            (tracker.GetComponent<Track>().lastDayReady == false && tracker.GetComponent<Track>().day == 11 ))
        {
            this.gameObject.SetActive(false);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(tracker.GetComponent<Track>().lastDayReady)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                GameObject fader = GameObject.Find("ExitFade");
                fader.GetComponent<Animator>().enabled = true;
                gameEnd = true;
            }
        }
    }
    private void Update()
    {
        if (gameEnd)
        {
            count++;
            if (count > 500)
            {
                Debug.Log(count);
                Application.Quit();
            }
        }
    }
}
