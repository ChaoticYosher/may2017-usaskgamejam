using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2_Movement : MonoBehaviour {
    public Transform leader;
    public float followDistance;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var heading = leader.GetComponent<Transform>().position - transform.position;
        heading.y = 0;
        var distance = heading.magnitude;
        var direction = heading / distance;
        transform.position = leader.position - followDistance * direction;
        transform.eulerAngles = direction;
	}
}
