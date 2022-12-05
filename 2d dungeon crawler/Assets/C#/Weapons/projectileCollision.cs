using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileCollision : MonoBehaviour
{
    //when projectile hits something
    void OnCollisionEnter2D (Collision2D collisionInfo){
        if (collisionInfo.collider.tag == "enemy"){
            ammoHit(collisionInfo);
        }
        else if (collisionInfo.collider.tag == "wall" || collisionInfo.collider.tag.Contains("door")){
            destroy();
        }
        else if (collisionInfo.collider.tag == "Player"){
            this.GetComponent<projectileDamage>().damagePlayer();
            destroy();
        }
    }

    //causes the enemy to lose health and then calls destroy()
    public void ammoHit(Collision2D enemy){
        enemy.gameObject.transform.GetChild(0).GetComponent<collision>().loseHealth(PlayerInfo.playerDamage + Weapons.currentDmg);
        destroy();
    }

    //destroys the projectile
    public void destroy(){
        Destroy(this.transform.parent.gameObject);
        Destroy(this.gameObject);
    }
}
