using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenShot : MonoBehaviour
{
    public float force;

    void Awake(){
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(weaponRotate.cos * force, weaponRotate.sin * force);
    }
}
