using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour {
Rigidbody2D m_Rigidbody;
float m_Speed;
	// Use this for initialization
	void Start () {
		m_Rigidbody = GetComponent<Rigidbody2D>();
		m_Speed = 10.0f;

	}

	// Update is called once per frame
	void Update () {
		m_Speed = 10 * Input.GetAxis("Horizontal");
		m_Rigidbody.velocity = transform.right * m_Speed;
	}
}
