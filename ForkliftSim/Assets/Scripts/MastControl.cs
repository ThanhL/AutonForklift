using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MastControl : MonoBehaviour {
	public float Mast_Vertical_Speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1")) {
			transform.Translate(new Vector3(0, Mast_Vertical_Speed, 0) * Time.deltaTime);
		} else if (Input.GetButton("Fire2")) {
			transform.Translate(new Vector3(0, -Mast_Vertical_Speed, 0) * Time.deltaTime);
		}
	}
}
