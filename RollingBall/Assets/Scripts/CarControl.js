#pragma strict
var wheelFL : WheelCollider;
var wheelFR : WheelCollider;
var wheelRL : WheelCollider;
var wheelRR : WheelCollider;
var maxTorque : float = 50000;
var max_steerAngle : float = 30;

function Start () {
	//rigidbody.centerOfMass.y = -0.9;

}

// Calls multiple times per frame
function FixedUpdate () {
	wheelFR.motorTorque = maxTorque * Input.GetAxis("Vertical");
	wheelFL.motorTorque = maxTorque * Input.GetAxis("Vertical");

	wheelRL.steerAngle = max_steerAngle * -Input.GetAxis("Horizontal");
	wheelRR.steerAngle = max_steerAngle * -Input.GetAxis("Horizontal");
	
}
