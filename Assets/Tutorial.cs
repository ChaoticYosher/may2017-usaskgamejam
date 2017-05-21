using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Invoke ("Tutorial1", 3);
	}

	void Tutorial1()
	{
		GetComponent<Text> ().text = "asdd";
	}
}
