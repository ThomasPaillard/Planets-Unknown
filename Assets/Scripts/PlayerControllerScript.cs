using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : LifeScript
{

    public float MoveSpeed = 15;
    private Vector3 MoveDirection;
    public float SpeedRotation;
    public GameObject Flammes;
    private GameObject attackFlames;
    bool IsShooting = false;
    private float timer = 0;
    public Transform StartAttackParticlesPosition;
    public Transform Planet;
    public GameObject BlockEffect;
    public bool NeedsPowers;
    public float SpeedMovement;
    public float MaxSpeed;

    void Update()
    {
        if (GetComponent<Rigidbody>().velocity.magnitude < MaxSpeed)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                GetComponent<Rigidbody>().AddForce(transform.forward * SpeedMovement);
                GetComponent<Animator>().SetBool("IsWalkingForward", true);
            }
            if (Input.GetKey(KeyCode.Q))
            {
                GetComponent<Rigidbody>().AddForce((-transform.right * SpeedMovement));
                GetComponent<Animator>().SetBool("IsWalkingLeft", true);
            }
            if (Input.GetKey(KeyCode.S))
            {
                GetComponent<Rigidbody>().AddForce(-transform.forward * SpeedMovement);
                GetComponent<Animator>().SetBool("IsWalkingBack", true);
            }
            if (Input.GetKey(KeyCode.D))
            {
                GetComponent<Rigidbody>().AddForce(transform.right * SpeedMovement);
                GetComponent<Animator>().SetBool("IsWalkingRight", true);
            }
            if (Input.GetKey(KeyCode.T) && NeedsPowers)
            {
                GetComponent<Animator>().SetBool("IsBlocking", true);
                Debug.Log("blocking");
                MoveDirection = new Vector3(0, 0, 0);
                BlockEffect.SetActive(true);
            }

            if (Input.GetKeyUp(KeyCode.Z))
            {
                GetComponent<Animator>().SetBool("IsWalkingForward", false);
            }
            if (Input.GetKeyUp(KeyCode.Q))
            {
                GetComponent<Animator>().SetBool("IsWalkingLeft", false);
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                GetComponent<Animator>().SetBool("IsWalkingRight", false);
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                GetComponent<Animator>().SetBool("IsWalkingBack", false);
            }
            if (Input.GetKeyUp(KeyCode.T) && NeedsPowers)
            {
                GetComponent<Animator>().SetBool("IsBlocking", false);
                MoveDirection = new Vector3(0, 0, 0);
                BlockEffect.SetActive(false);

            }
        }
    }
    public override void Damage(int d)
    {
        base.Damage(d);
        GetComponent<Animator>().SetInteger("Pv", Pv);
        if (Pv <= 1)
        {
           // DeadScreen.SetActive(true);
            this.GetComponent<CameraPlayerScript>().enabled = false;

           Cursor.visible = true;
           this.enabled = false;

        }
    }
}
