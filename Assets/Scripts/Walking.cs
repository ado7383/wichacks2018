using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour {
Rigidbody2D m_Rigidbody;
SpriteRenderer m_SpriteRenderer;
float m_Speed;
    private bool initialize;
	// Use this for initialization
	void Start () {
		m_Rigidbody = GetComponent<Rigidbody2D>();
		m_SpriteRenderer = GetComponent<SpriteRenderer>();
		m_Speed = 10.0f;
	}

	// Update is called once per frame
	void Update () {
		m_Speed = 10 * Input.GetAxis("Horizontal");
		m_Rigidbody.velocity = transform.right * m_Speed;
		if( m_Speed < 0){
			m_SpriteRenderer.flipX = true;
		}else if(m_Speed > 0){
			m_SpriteRenderer.flipX = false;
		}
	}
    
}
