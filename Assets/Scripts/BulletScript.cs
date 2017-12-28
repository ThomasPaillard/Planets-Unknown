using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class BulletScript : MonoBehaviour {
    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.GetComponent<lifescript>
        //{
        if (collision.gameObject.GetComponent<LifeScript>())
        {
            collision.gameObject.GetComponent<LifeScript>().Damage(5);
        }
        //
        //}
    }
    void OnParticleCollision(GameObject other)
    {
        Rigidbody body = other.GetComponent<Rigidbody>();
        if (body)
        {
            Vector3 direction = other.transform.position - transform.position;
            direction = direction.normalized;
            body.AddForce(direction * 5);
        }
    }

}
