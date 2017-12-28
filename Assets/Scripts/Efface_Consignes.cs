using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efface_Consignes : MonoBehaviour {

	public float timer;

	void Start () {
		timer = 0;
	}
	

	void Update () {
		timer += Time.deltaTime;
		if (timer > 10) {
			Destroy (gameObject);
		}
	}
}
