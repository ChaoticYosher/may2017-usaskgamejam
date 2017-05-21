using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPlayerInMe : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		//disable render for all but Room5
		if(transform.name != "Room5")
		{
			foreach (Transform child in transform) {
				child.gameObject.SetActive (false);
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			//for each child, enable render
			foreach (Transform child in transform) {
				child.gameObject.SetActive (true);
			}
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			//for each child, disable render
			foreach (Transform child in transform) {
				child.gameObject.SetActive (false);
			}
		}
	}
}
