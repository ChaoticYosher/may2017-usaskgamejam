using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){

		Debug.Log (col.gameObject.name);

		if (col.gameObject.name == "HammerCollect") {
			//turn on hammer script
			Debug.Log("HammeR");
			GetComponent<TheHammer>().enabled = true;
			Destroy (col.gameObject);
		}
	}
}
