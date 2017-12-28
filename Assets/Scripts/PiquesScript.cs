using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiquesScript : MonoBehaviour {

	public float Speed;
	public bool IsOpen = false;
	public Vector3 StartPosition;
	public Vector3 EndPosition;

	private float timer = 0;

	void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Player") 
		{
			IsOpen = true;
			timer = 0;
		}
	}

	void OnTriggerExit(Collider c)
	{
		if (c.tag == "Player") 
		{
			IsOpen = false;
			timer = 1;
		}
	}

	void Update () {


		if(IsOpen)
			timer += Time.deltaTime;
		else
			timer -= Time.deltaTime;

		transform.localPosition = Vector3.Lerp (StartPosition, EndPosition, timer);
	}
}