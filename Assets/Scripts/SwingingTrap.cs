﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingingTrap : MonoBehaviour {

	int direction = 1;
	Vector3 rotatePoint;
	public bool sideOrForward = true;
	public int rotateSpeed = 20;

	// Use this for initialization
	void Start () {
		rotatePoint = new Vector3 (transform.position.x, transform.position.y+3, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {

		if (sideOrForward == true) {
			//Debug.Log (transform.rotation.x);

			if (transform.rotation.x > 0.5) {
				direction = -1;
			} else if (transform.rotation.x < -0.5) {
				direction = 1;
			}

			transform.RotateAround (rotatePoint, Vector3.right, direction * rotateSpeed * Time.deltaTime);
		}

		if (sideOrForward == false) {
			//Debug.Log (transform.rotation.x);

			if (transform.rotation.z > 0.5) {
				direction = -1;
			} else if (transform.rotation.z < -0.5) {
				direction = 1;
			}

			transform.RotateAround (rotatePoint, Vector3.forward, direction * rotateSpeed * Time.deltaTime);
		}

	}
}
