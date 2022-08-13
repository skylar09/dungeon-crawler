using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public int health = 4;
    public int damage = 2;
    public int defense = 0;
    public int deathGold = 5;

    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        //checks for the tag on the object it collides with
        if (collisionInfo.collider.tag == "weapon")
        {
            if (Weapons.currentDamage - defense <= 0)
            {
                health -= 1;
            }

            else 
            {
                health -= Weapons.currentDamage - defense;
            }
        }

        //makes player take damage for hitting an enemy
        if (collisionInfo.collider.tag == "Player")
        {
            damagePlayer();

            GameObject player = collisionInfo.gameObject;

            // StartCoroutine(Wait);
        }
    }

    void Update()
    {
        //when the enemy is dead
        if (health <= 0)
        {
            //gives the player gold
            PlayerInfo.gold += deathGold;

            //picks random number and decides if it should drop an item

            int shouldDrop = Random.Range(0, 101);

            if (shouldDrop >= 0)
            {
                dropItem.drop = true;
                dropItem.enemyLocation = this.GetComponent<Transform>().position;
            }

            //destroys (kills) the enemy
            Destroy(gameObject);
        }
    }

    public void damagePlayer()
    {
         //makes sure the player loses at least 1 health
            if (damage - PlayerInfo.playerDefense <= 0 || PlayerInfo.playerDefense - damage >= 4)
            {
                PlayerInfo.playerHealth -= 1;
            }
            else
            {
                //player loses health equal to the difference in player defense and enemy dmg
                PlayerInfo.playerHealth -= damage - PlayerInfo.playerDefense;
            }
    }

    // this is used to wait a certain amount of time before doing something
    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(1);
        
        //make it so player takes damage if the enemy is still touching
        // if ()
        // {
        //     damagePlayer();
        //     StartCoroutine(Wait);
        // }
    }
}
