using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpNote : MonoBehaviour {
    public int dayForNote;
    public string fadeObject;
    private void Start()
    {
        GameObject tracker = GameObject.FindGameObjectWithTag("Track");
        if(tracker.GetComponent<Track>().sleep == true || tracker.GetComponent<Track>().day != dayForNote ||
            tracker.GetComponent<Track>().fed == false)
        {
            this.gameObject.SetActive(false);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject tracker = GameObject.FindGameObjectWithTag("Track");
            tracker.GetComponent<Track>().sleep = true;
            this.gameObject.SetActive(false);
            GameObject faded = GameObject.Find(fadeObject);
            faded.GetComponent<Animator>().enabled = true;
        }
    }
}
