using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotationScript : MonoBehaviour {

    private Transform CamTransform;
    public float SpeedRotation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        Debug.Log(y + " " + x);

        transform.eulerAngles += new Vector3(-y, 0, 0) * SpeedRotation;
        //Debug.Log(CamTransform.eulerAngles);
        float XClamp = Mathf.Clamp(transform.eulerAngles.x + x , 60, -60);
        float YClamp = Mathf.Clamp(transform.eulerAngles.y + y, 60, -60);
        transform.eulerAngles += new Vector3(0, x, 0) * SpeedRotation;
    }
}
