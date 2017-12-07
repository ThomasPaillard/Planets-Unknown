using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class GravityBodyScript : MonoBehaviour {

    public GravityAttractorScript attractor;
    private Transform MyTransform;

    void Start ()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

        MyTransform = transform;
	}
	
	
	void FixedUpdate ()
    {
        if (attractor)
        {
            attractor.Attract(MyTransform);
        }
	}
}
