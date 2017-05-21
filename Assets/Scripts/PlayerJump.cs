using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour {

	public int jumpForce = 1;
	private bool canJump, wantToJump;
	private Rigidbody selfRigidBody;

	// Use this for initialization
	void Start () {
		selfRigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (canJump && wantToJump) {
			canJump = false;
			wantToJump = false;
			selfRigidBody.AddForce (0, jumpForce, 0, ForceMode.Impulse);
		}
	}

	void Update()
	{
		if (Input.GetKeyUp ("space") && canJump) {
			wantToJump = true;
		}

	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.layer == 8) {
			//Debug.Log("Boop" + GetComponent<Renderer>().material);
			canJump = true;
		} else {
			canJump = false;
		}
	}

	void OnCollisionEnter(Collision coll)
	{
		if(coll.gameObject.layer != 8)
		canJump = false;
	}
}
