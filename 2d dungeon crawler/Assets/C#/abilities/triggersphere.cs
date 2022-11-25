using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggersphere : MonoBehaviour
{
    public GameObject lightningBolt;
    public static Vector2 pos;

    public void OnTriggerEnter2D(Collider2D collider){
        if (collider == null){
            Destroy(this.gameObject);
            return;
        }
        if (collider.tag == "enemy"){
            Hit h = collider.gameObject.GetComponent<Hit>();
            if (h == null){
            lightningBolt.GetComponent<lightningstrike>().makeLightning(pos, collider.transform.position);
            h = collider.gameObject.AddComponent<Hit>();
            Instantiate(this.gameObject, collider.transform.position, Quaternion.identity);
            }
            Destroy(this.gameObject);
        }
    }    
}