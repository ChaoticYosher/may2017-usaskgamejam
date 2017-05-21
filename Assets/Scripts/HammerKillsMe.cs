using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerKillsMe : MonoBehaviour {

	public GameObject thingToTrigger;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "Hammer") {
			Destroy(gameObject);
			thingToTrigger.SetActive (false);
		}
	}

}
