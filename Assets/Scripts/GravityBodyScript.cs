using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class GravityBodyScript : MonoBehaviour {

    GravityAttractorScript attractor;
    private Transform MyTransform;

    void Start ()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

        MyTransform = transform;
	}
	
	
	void FixedUpdate ()
    {
        attractor = GameObject.FindWithTag("Planet").GetComponent<GravityAttractorScript>();
        if (attractor)
        {
            attractor.Attract(MyTransform);
        }
	}
}
