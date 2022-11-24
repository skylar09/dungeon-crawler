using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggersphere : MonoBehaviour
{
    public GameObject lightningBolt;

    public void OnTriggerEnter2D(Collider2D collider){
        if (collider == null)
            return;
        if (collider.tag == "enemy"){
            lightningBolt.GetComponent<lightningstrike>().makeLightning(collider.transform.position);
        }
    }
}
