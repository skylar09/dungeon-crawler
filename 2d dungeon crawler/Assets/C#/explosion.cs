using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public GameObject Explosion;

    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        //checks for the tag on the object it collides with

        //make it so if it hits anything it explodes
        if (collisionInfo.collider.tag != "boss")
        {
            Instantiate(Explosion, this.GetComponent<Transform>().position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
