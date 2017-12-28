using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelScript : MonoBehaviour {

	void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
			#pragma warning disable CS0618 // Le type ou le membre est obsolète
            Application.LoadLevel(name: "Planet 3");
			#pragma warning restore CS0618 // Le type ou le membre est obsolète
        }
    }
}
