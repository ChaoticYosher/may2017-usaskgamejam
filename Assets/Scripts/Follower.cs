using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour {
    ArrayList followers;
    public GameObject[] followableObjects;
    public float followDistance, grabDistance;
    // Use this for initialization
	void Start () {
		followers = new ArrayList();
	}
	
	// Update is called once per frame
	void Update () {
        for( int i = 0 ; i < followers.Count-1 ; i++ ){
            Follow((GameObject)followers[i], (GameObject)followers[i - 1]);
        }
        if (Input.GetKeyDown("Fire")) {
            AddFollower( FindClosest() );
        }
	}

    GameObject FindClosest() {
        if (followableObjects.Length > 0)
        {
            float t;
            GameObject min = followableObjects[0];
            float minDist = Vector3.Distance( min.GetComponent<Transform>().position, transform.position );
            foreach (GameObject go in followableObjects) {
                t = Vector3.Distance(min.GetComponent<Transform>().position, go.GetComponent<Transform>().position);
                if (t < minDist) {
                    minDist = t;
                    min = go;
                }
            }
            return ( minDist < grabDistance ) ? min : null;
        }
        else
        {
            return null;
        }
    }

    void Follow(GameObject leader, GameObject follower){
        var leadPos = leader.GetComponent<Transform>().position;
        Transform followTransform = follower.GetComponent<Transform>();
        var heading = leadPos - followTransform.position;
        heading.y = 0;
        var distance = heading.magnitude;
        var direction = heading / distance;
        followTransform.position = leadPos - followDistance * direction;
        followTransform.LookAt(leadPos);
    }

    void AddFollower( GameObject follower ){
        if (follower is GameObject && !followers.Contains(follower)) {
            followers.Add(follower);
        } else {
            Debug.Log("Can't add {0}", follower);
        }
    }
}
