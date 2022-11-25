using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggersphere : MonoBehaviour
{
    public GameObject lightningBolt;
    public static Vector2 pos;

    //if the triggersphere hits an enemy it makes a lightning bolt and another triggersphere
    public void OnTriggerEnter2D(Collider2D collider){
        if (collider.tag == "enemy"){
            //checks if an enemy has been hit recently
            Hit h = collider.gameObject.GetComponent<Hit>();
            if (h == null){
            //makes a lightning bolt
            lightningBolt.GetComponent<lightningstrike>().makeLightning(pos, collider.transform.position);
            //adds the Hit script to the enemy
            h = collider.gameObject.AddComponent<Hit>();
            //makes a sphereTrigger with .5 second timer until it is destoryed
            Destroy(Instantiate(this.gameObject, collider.transform.position, Quaternion.identity), .5f);
            //destroys this triggersphere
            Destroy(this.gameObject);
            }
        }
    }
}