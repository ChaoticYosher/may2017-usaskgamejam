using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPlayerInMe : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			//for each child, enable render
			foreach (Transform child in transform) {
				if (child.GetComponent<Renderer> ())
				child.GetComponent<Renderer> ().enabled = true;
			}
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			//for each child, disable render
			foreach (Transform child in transform) {
				if (child.GetComponent<Renderer> ())
				child.GetComponent<Renderer> ().enabled = false;
			}
		}
	}
}
