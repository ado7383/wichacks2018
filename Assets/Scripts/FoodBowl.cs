using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBowl : MonoBehaviour {
    public Sprite empty;
    public Sprite full;
    private SpriteRenderer spriteRenderer;
    
	// Use this for initialization
	void Start () {
        GameObject tracker = GameObject.FindGameObjectWithTag("Track");
        spriteRenderer = GetComponent<SpriteRenderer>();
        if( tracker.GetComponent<Track>().fed == true)
        {
            spriteRenderer.sprite = full;
        }
        else if( spriteRenderer.sprite == null)
        {
            spriteRenderer.sprite = empty;
        }
	}
	

    private void OnTriggerStay2D(Collider2D collision)
    {
        GameObject tracker = GameObject.FindGameObjectWithTag("Track");

        if(Input.GetKey(KeyCode.Space))
        {
            spriteRenderer.sprite = full;
            tracker.GetComponent<Track>().fed = true;
        }
    }
}
