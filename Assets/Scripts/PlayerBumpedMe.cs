using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBumpedMe : MonoBehaviour {

	Material iron;
	Material slime;
	public GameObject thingToAffect;
	bool thingActive = false;

	// Use this for initialization
	void Start () {
		slime = Resources.Load("LightUp", typeof(Material)) as Material;
		iron = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space"))
		{
			ResetColour ();
		}
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Player" && thingActive==false){
			Debug.Log("Boop" + GetComponent<Renderer>().material);
			GetComponent<Renderer> ().material = slime;
			thingToAffect.SetActive (true);
			thingActive = true;
		}else if(col.gameObject.tag == "Player" && thingActive==true){
			Debug.Log("Boop" + GetComponent<Renderer>().material);
			GetComponent<Renderer> ().material = iron;
			thingToAffect.SetActive (false);
			thingActive = false;
		}

	}

	void ResetColour()
	{
		GetComponent<Renderer> ().material = iron;
	}
}
