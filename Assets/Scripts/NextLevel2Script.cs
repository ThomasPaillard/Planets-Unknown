using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel2Script : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		if(col.tag == "Player"){
			#pragma warning disable CS0618 // Le type ou le membre est obsolète
			Application.LoadLevel(name: "Planet 2 - Desert");
			#pragma warning restore CS0618 // Le type ou le membre est obsolète
		}
	}
}
