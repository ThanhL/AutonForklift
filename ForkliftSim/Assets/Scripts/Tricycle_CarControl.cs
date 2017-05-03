using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Tricycle_CarControl : MonoBehaviour {

	// Colliders
	public WheelCollider rearWheel_C;
	public WheelCollider frontleftWheel_C;
	public WheelCollider frontrightWheel_C;

	// Max Torque Applied
	public float MaxTorque;
	public float steerAngle;

	void Start() {

	}


	// Called before rendering a frame
	void Update() {


	}

	// Called  before performing any physics calc
	// Place physics calculation here
	void FixedUpdate() {

		// Torque
		rearWheel_C.motorTorque = MaxTorque * Input.GetAxis ("Vertical");

		frontleftWheel_C.motorTorque = MaxTorque * Input.GetAxis ("Vertical");
		frontrightWheel_C.motorTorque = MaxTorque * Input.GetAxis ("Vertical");

		// Steering
		rearWheel_C.steerAngle = steerAngle * -Input.GetAxis("Horizontal");

	}
}
