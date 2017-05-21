﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerKillsMe : MonoBehaviour {

	public GameObject thingToTrigger;
	public AudioClip SoundFX;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "Hammer") {
			Destroy(gameObject);
			if (thingToTrigger) {
				if (thingToTrigger.active == true) {
					thingToTrigger.SetActive (false);
				} else {
					thingToTrigger.SetActive (true);
				}
			}
//			if (SoundFX) {
//				SoundFX.Play ();
//			}
		}
	}

}
