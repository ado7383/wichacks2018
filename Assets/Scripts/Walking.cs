using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour {
Rigidbody2D m_Rigidbody;
SpriteRenderer m_SpriteRenderer;
float m_Speed;
bool canMove;
bool canMoveLeft;
bool canMoveRight;
    private bool initialize;
	// Use this for initialization
	void Start () {
		m_Rigidbody = GetComponent<Rigidbody2D>();
		m_SpriteRenderer = GetComponent<SpriteRenderer>();
		m_Speed = 10.0f;
    canMoveLeft = true;
    canMoveRight = true;
	}

	// Update is called once per frame
	void Update () {
		m_Speed = 20 * Input.GetAxis("Horizontal");
    if( m_Speed < 0 && canMoveLeft){
      m_Rigidbody.velocity = transform.right * m_Speed;
			m_SpriteRenderer.flipX = true;
		}else if(m_Speed > 0 && canMoveRight){
      m_Rigidbody.velocity = transform.right * m_Speed;
			m_SpriteRenderer.flipX = false;
		}
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Hit Wall");
            canMoveRight = false;
        }

    }
    private void OnTriggerExit2D(Collider2D collision){
      if(collision.gameObject.CompareTag("Wall")){
        canMoveRight = true;
      }
    }

}
