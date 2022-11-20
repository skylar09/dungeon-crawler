using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenShot : MonoBehaviour
{
    //velocity of projectile
    public float force;

    //when projectile first instantiated applies part of force in x and y direction based on angle its facing
    void Awake(){
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(weaponRotate.cos * force, weaponRotate.sin * force);
    }
}
