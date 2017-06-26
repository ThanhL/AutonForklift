using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	public float speed;
	private Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody> ();
	}


	// Called before rendering a frame
	void Update() {
		

	}

	// Called  before performing any physics calc
	// Place physics calculation here
	void FixedUpdate() {
		float moveHor = Input.GetAxis("Horizontal");
		float moveVer = Input.GetAxis("Vertical");

		//Vector3 movement = new Vector3 (moveHor, 0.0f, moveVer);
		Vector3 movement = new Vector3 (moveHor, 0.0f, moveVer);

		rb.AddForce (movement * speed);
	}
}
