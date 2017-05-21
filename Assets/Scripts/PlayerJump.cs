using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour {

	public int jumpForce = 10;
	private bool canJump;
	private Rigidbody selfRigidBody;

	// Use this for initialization
	void Start () {
		selfRigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (canJump) {
			canJump = false;
			selfRigidBody.AddForce (0, jumpForce, 0, ForceMode.Impulse);
		}
	}

	void Update()
	{
		if (Input.GetKeyUp ("space")) {
			canJump = true;
		}

	}
}
