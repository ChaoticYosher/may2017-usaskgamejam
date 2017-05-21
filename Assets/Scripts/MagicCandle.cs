using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicCandle : MonoBehaviour {

	public GameObject MagicLight;
	private Vector3 newPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp ("space")) {
			//drop light
			newPosition = transform.position;
			newPosition.y += 2;
			MagicLight.transform.position = newPosition;
		}
	}
}
