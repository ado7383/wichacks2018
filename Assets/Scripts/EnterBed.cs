using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterBed : MonoBehaviour {
    
    private void OnTriggerStay2D(Collider2D collision){
	if(Input.GetKey(KeyCode.Space)){
        GameObject tracker = GameObject.FindGameObjectWithTag("Track");
        Debug.Log(tracker.GetComponent<Track>().day);
        if( tracker.GetComponent<Track>().sleep == true)
            {
                GameObject faded = GameObject.Find("BlackFade");
                faded.GetComponent<Animator>().enabled = true;
                tracker.GetComponent<Track>().day++;
                tracker.GetComponent<Track>().sleep = false;
            }
	}
}
}
