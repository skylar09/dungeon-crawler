using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public int health = 4;
    public int damage = 2;
    public int defense = 0;
    public int deathGold = 5;
    public float moveSpeed = 1.5f;

    void Start()
    {
        this.GetComponent<enemyMovement>().moveSpeed = moveSpeed;
    }

    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        //checks for the tag on the object it collides with
        if (collisionInfo.collider.tag == "weapon")
        {
            loseHealth();
        }

        //makes player take damage for hitting an enemy
        if (collisionInfo.collider.tag == "Player")
        {
            damagePlayer();

            // GameObject player = collisionInfo.gameObject;

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

            itemDrop();

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

    public void itemDrop()
    {
        //picks random number and decides if it should drop an item

        int shouldDrop = Random.Range(0, 101);

        if (shouldDrop <= 10)
        {
            dropItem.drop = true;
            dropItem.enemyLocation = this.GetComponent<Transform>().position;
        }
    }

    public void loseHealth()
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
}
