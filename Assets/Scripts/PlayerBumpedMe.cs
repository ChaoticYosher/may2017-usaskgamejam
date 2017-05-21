using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBumpedMe : MonoBehaviour {

	//public GameObject thingToAffect;
	public Material m1_base, m2_active;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
//		if(Input.GetKeyDown("space"))
//		{
//			ResetColour ();
//		}
	}

	void OnCollisionEnter(Collision col){

		//if it is off turn it on, if it is on turn it off
//		if(col.gameObject.tag == "Player" && thingActive==false){
//			Debug.Log("Boop" + GetComponent<Renderer>().material);
//			GetComponent<Renderer> ().material = m2_active;
//			thingToAffect.SetActive (true);
//			thingActive = true;
//		}else if(col.gameObject.tag == "Player" && thingActive==true){
//			Debug.Log("Boop" + GetComponent<Renderer>().material);
//			GetComponent<Renderer> ().material = m1_base;
//			thingToAffect.SetActive (false);
//			thingActive = false;
//		}

		//toggle on/off for all children of thingToAffect

		foreach (Transform child in transform) {
			//Debug.Log("Active:" + child.gameObject.activeSelf);
			if (col.gameObject.tag == "Player" && !child.gameObject.activeSelf) {
				GetComponent<Renderer> ().material = m2_active;
				child.gameObject.SetActive (true);
			}
			else if(col.gameObject.tag == "Player" && child.gameObject.activeSelf){
				GetComponent<Renderer> ().material = m1_base;
				child.gameObject.SetActive (false);
			}
			
		}

	}

	void ResetColour()
	{
		GetComponent<Renderer> ().material = m1_base;
	}
}
