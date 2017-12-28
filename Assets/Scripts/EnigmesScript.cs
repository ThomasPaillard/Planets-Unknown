using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmesScript : MonoBehaviour {

    public GameObject enigme;
    public TMPro.TextMeshProUGUI UIText;

    private void Start()
    {
        Cursor.visible = false;
    }

    void OnTriggerEnter(Collider col)
    {
		if(col.tag == "Player")
        {
            enigme.SetActive(true);
            this.gameObject.SetActive(false);

            if (enigme.tag == "Start")
            {
                UIText.text = "Explore les dalles, une d’elles est correct, les autres te mèneront aux côtés d’Anubis";
                Debug.Log("Bonjour");
            }

            if (enigme.tag == "Enigme 2")
            {
                UIText.text = "Va aux côté des obélisques, et les dunes t’indiqueront la voie à suivre";
                Debug.Log("Bye");
            }
              
            if (enigme.tag == "Enigme 3")
                UIText.text = "Les pierres ont bloqué l’accès, mais l’une d’elles se montrera peut-être clémente";

            if (enigme.tag == "Enigme 4")
                UIText.text = "Ra éclaire son chemin, et sa lumière se reflète sur les pyramides";

            if (enigme.tag == "Enigme 5")
                UIText.text = "La fin est souvent le début";

            if (enigme.tag == "Portail")
                UIText.text = "La chemin s'ouvre vers le destin de l'élu";

            Destroy(this.gameObject);
        }

    }
}
