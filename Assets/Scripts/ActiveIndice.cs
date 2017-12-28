using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveIndice : MonoBehaviour {

	public float Timezer;
	public TextMesh Text;



	void Start (){
		Timezer = 0;
		Text = GetComponent<TextMesh> ();
	}
	
	// Update is called once per frame
	void Update () {
		Timezer += Time.deltaTime;
		if (Timezer < 50) {
			Text.characterSize = 0f;
		}

		if (Timezer > 50) {
			Text.characterSize = 0.2f;
		}
	}
}
