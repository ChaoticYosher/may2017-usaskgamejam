using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Follower : MonoBehaviour {
    public ArrayList followers;
    public GameObject[] followableObjects;
    public float followDistance, topSpeed;
    public GameObject me;
    // Use this for initialization
	void Start () {
        Debug.Log(me);
		followers = new ArrayList();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (followers.Count > 0) {
            Follow( me, (GameObject) followers[0] );
            for (int i = 0; i < followers.Count - 1; i++) {
                Follow((GameObject)followers[i], (GameObject)followers[i + 1]);
            }
        }
        /**
        if (Input.GetAxis("Fire1") > 0) {
            Debug.Log(FindClosest());
            AddFollower( FindClosest() );
        }
         */
	}

    void OnTriggerEnter(Collider coll) {
        Debug.Log(coll.gameObject);
        AddFollower( coll.gameObject );
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
            return minDist < 2 ? min : null;
        }
        else
        {
            return null;
        }
    }

    void Follow(GameObject leader, GameObject follower){
        var leadPos = leader.GetComponent<Transform>().position;
        Transform followTransform = follower.GetComponent<Transform>();
        followTransform.LookAt(leadPos);
        var distanceAway = Vector3.Distance(leadPos, followTransform.position) - followDistance;
        var speed = Mathf.Min( topSpeed, distanceAway );
        followTransform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void AddFollower( GameObject follower ){
        Debug.Log(follower);
        for (int i = 0; i < followableObjects.Length; i++)
        {
            if ( follower == followableObjects[i] )
            {
                if (follower is GameObject && !followers.Contains(follower))
                {
                    followers.Add(follower);
                }
                else
                {
                    Debug.Log("Can't add ", follower);
                }
            }
        }
        Debug.Log("Can't add ", follower);
    }
}
