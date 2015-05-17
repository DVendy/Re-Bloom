using UnityEngine;
using System.Collections;

public class Meteor : MonoBehaviour {

	// gravity constant
	public float g=9.8f;
	Vector3 gravity;
	void Update(){

	}
	
	void FixedUpdate() {
		// normalize axis
		gravity = new Vector3 (
			Input.acceleration.x,
			0,
			Input.acceleration.y
			) * g;
		
		GetComponent<Rigidbody>().AddForce (gravity, ForceMode.Acceleration);
	}
}
