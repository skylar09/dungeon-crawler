using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knockback : MonoBehaviour
{
    Rigidbody2D enemy;

    //adds force to an enemy so as to do knockback
    void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        if (collisionInfo.tag == "weapon" && Weapons.canAttack == false)
        {
            int thrust = collisionInfo.gameObject.GetComponent<weaponStats>().knockback;
            if (thrust > 0){
                enemy = this.transform.parent.gameObject.GetComponent<Rigidbody2D>();
                //makes it so the enemy can't move while taking knockback
                this.transform.parent.gameObject.GetComponent<enemyMovement>().canMove = false;

                Vector2 difference = transform.position - collisionInfo.transform.position;
                difference = difference.normalized * thrust;
                //the impulse is a force applied in one frame
                this.transform.parent.gameObject.GetComponent<Rigidbody2D>().AddForce(difference, ForceMode2D.Impulse);

                StartCoroutine(knockbackOccur());
            }
        }
    }

    //after the knockback is over the enemy velocity resets and it can move again
    IEnumerator knockbackOccur()
    {
        yield return new WaitForSecondsRealtime(.5f);
        enemy.velocity = new Vector2(0,0);
        this.transform.parent.gameObject.GetComponent<enemyMovement>().canMove = true;
    }
}
