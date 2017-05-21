using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour {

	private Text texty;


	// Use this for initialization
	void Start () {
		texty = GetComponent<Text>();
		Tutorial0 ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void blank()
	{
		texty.text = "";
	}

	void Tutorial0()
	{
		texty.text = "Use WASD to move around!";
		Invoke ("blank", 5);
		Invoke ("Tutorial1", 7);
	}

	void Tutorial1()
	{
		texty.text = "Hit Spacebar to re-center camera.";
		Invoke ("blank", 5);
	}
}
