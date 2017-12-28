using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScript : MonoBehaviour {

    public TMPro.TextMeshProUGUI UIText;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        UIText.text = "Suivant";
	}
}
