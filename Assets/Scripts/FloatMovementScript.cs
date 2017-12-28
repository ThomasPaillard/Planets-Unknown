using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatMovementScript : MonoBehaviour {

	public float amplitude = 1f;
	public float speed = 1f;
    public Transform Spaceship;

    private float startPosY;
	private float startPosX;
	private float startPosZ;
	private Vector3 newPos;

	void Start () 
	{
		startPosY = transform.position.y;
		startPosX = transform.position.x;
		startPosZ = transform.position.z;

	}

	void Update () 
	{
		newPos.y = startPosY + amplitude * Mathf.Cos (speed * Time.time);
		newPos.x = startPosX + amplitude * Mathf.Sin (speed * Time.time);
		newPos.z = startPosZ + amplitude * Mathf.Cos (speed * Time.time);

		transform.position = newPos;

		transform.Rotate(0, 150 * Time.deltaTime, 0);

    }
}
