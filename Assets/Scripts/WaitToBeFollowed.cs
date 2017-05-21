using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitToBeFollowed : MonoBehaviour {
    void OnCollisionEnter( Collision coll ){
        var target = coll.collider.transform.gameObject;
        Debug.Log("Hi " + target);
    }
}
