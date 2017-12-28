using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ancienscript : LifeScript
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

    void Update()
    {
        MoveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        if (Input.GetKey(KeyCode.Z))
        {
            GetComponent<Animator>().SetBool("IsWalkingForward", true);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            GetComponent<Animator>().SetBool("IsWalkingLeft", true);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Animator>().SetBool("IsWalkingBack", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
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
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(MoveDirection) * MoveSpeed * Time.deltaTime);
    }
    
}
