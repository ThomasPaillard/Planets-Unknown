using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleted : MonoBehaviour {

    int nbrObjects = 10;
    public GameObject victoryScreen;
    public GameObject InstructionsScreen;
    public TMPro.TextMeshProUGUI UI;
    private bool gamefinished;
    private GameObject Player;
    // Use this for initialization
    void Start () {
        Cursor.visible = false;
        UI.text = "Flammix restants: " + nbrObjects;
        gamefinished = false;
        Player = GameObject.FindWithTag("Player");

    }

    private void Update()
    {
        if (gamefinished)
        {
            Player.GetComponent<Rigidbody>().AddForce(transform.up * 100);
        }
    }

    // Update is called once per frame
    public void UpdateNbrObjects (int less) {
        nbrObjects -= less;
        UI.text = "Flammix restants: " + nbrObjects;
        if (nbrObjects <= 0)
        {
            victoryScreen.SetActive(true);
            Player.GetComponent<CameraPlayerScript>().enabled = false;
            Player.GetComponent<PlayerControllerScript>().enabled = false;
            InstructionsScreen.SetActive(false);
            // other.GetComponent<GravityBodyScript>().enabled = false;
            Player.GetComponent<Rigidbody>().AddForce(transform.up * 100);
            gamefinished = true;
        }
    }
}
