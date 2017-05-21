using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerKillsMe : MonoBehaviour {

	public GameObject thingToTrigger;
    private AudioSource audioSource;
	private bool destoyed = false;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {

		if (other.gameObject.name == "Hammer" && destoyed == false) {

			if (audioSource.clip) {
				audioSource.Play ();
			}

			Invoke ("destroyMe", audioSource.clip.length);

			if (thingToTrigger) {
				if (thingToTrigger.active == true) {
					thingToTrigger.SetActive (false);
				} else {
					thingToTrigger.SetActive (true);
				}
			}

			destoyed = true;
		}
	}

	void destroyMe()
	{
		Destroy(gameObject);
	}

}
