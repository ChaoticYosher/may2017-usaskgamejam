using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheHammer : MonoBehaviour {

	public GameObject hammer;
	private Vector3 newPosition;
	private Rigidbody hammerBody;

	// Use this for initialization
	void Start () {
		hammerBody = hammer.GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp ("space")) {
			//respawn hammer
			newPosition = transform.position;
			newPosition.y += -0.5f;
			hammer.transform.position = newPosition;

			//throw hammer
			hammerBody.rotation = Quaternion.identity;
			hammerBody.velocity = Vector3.zero;
			hammerBody.AddForce(transform.forward * 25, ForceMode.Impulse);
		}
	}
}
