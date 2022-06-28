using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public GameObject Explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        //checks for the tag on the object it collides with

        //make it so if it hits anything it explodes
        if (collisionInfo.collider.tag == "Player")
        {
            Instantiate(Explosion, this.GetComponent<Transform>().position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
