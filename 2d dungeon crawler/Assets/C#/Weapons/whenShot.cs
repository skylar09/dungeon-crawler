using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenShot : MonoBehaviour
{
    //velocity of projectile
    public float force;

    //when projectile first instantiated applies part of force in x and y direction based on angle its facing
    void Awake(){
        if (this.GetComponent<weaponStats>() != null)
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(weaponRotate.cos * force, weaponRotate.sin * force);
        else{
            
            float cos = Mathf.Cos(enemyShoot.angle / 360 * 2 * Mathf.PI);
            float sin = Mathf.Sin(enemyShoot.angle / 360 * 2 * Mathf.PI);
            Vector3 newDirection = Vector3.RotateTowards(transform.position, PlayerInfo.playerLocation, 10f, 0f);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(cos * force, sin * force);
        }
    }
}
