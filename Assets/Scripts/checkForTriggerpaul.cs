using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkForTriggerpaul : MonoBehaviour {

	public GameObject portail;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
	{
        if (other.tag == "Player")
        {
			Debug.Log ("test");
			portail.SetActive (true);
                Destroy(this.gameObject);
        }
     }
}
