using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkForTrigger : MonoBehaviour {

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("player is in trigger");
            if (Input.GetKey(KeyCode.T))
                {
                var manager = GameObject.FindWithTag("GameManager");
                manager.GetComponent<LevelCompleted>().UpdateNbrObjects(1);
                Destroy(this.gameObject);
            }
        }
     }
}
