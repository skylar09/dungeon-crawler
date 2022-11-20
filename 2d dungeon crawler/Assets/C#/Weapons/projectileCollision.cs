using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileCollision : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D collisionInfo){
        if (collisionInfo.collider.tag == "enemy"){
            ammoHit(collisionInfo);
        }
        else if (collisionInfo.collider.tag == "wall" ||collisionInfo.collider.tag.Contains("door")){
            destroy();
        }
    }

    public void ammoHit(Collision2D enemy){
        enemy.gameObject.transform.GetChild(0).GetComponent<collision>().loseHealth();
        destroy();
    }

    public void destroy(){
        Destroy(this.transform.parent.gameObject);
        Destroy(this.gameObject);
    }
}
