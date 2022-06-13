using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D (Collision2D collision)
    {
        //checks for the tag on the object it collides with
        if (collision.collider.tag == "Weapon")
        {
            Debug.Log("ouch");

            enemyInfo.enemyHealth --;


        }
    }
}
