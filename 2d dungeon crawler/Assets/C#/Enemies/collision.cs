using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    //enemy stats
    public int health;
    public int damage;
    public int defense;
    public int deathGold;
    public float moveSpeed;

    //updates the health of the enemy when first spawned based on current level
    void Awake()
    {
        health *= pauseMenu.whichScene;
    }

    void Start()
    {
        //sets the move speed in enemyMovement of the parent of this gameObject
        this.transform.parent.gameObject.GetComponent<enemyMovement>().moveSpeed = moveSpeed;
    }

     void Update()
    {
        //when the enemy is dead
        if (health <= 0)
        {
            //gives the player gold
            PlayerInfo.gold += deathGold;

            itemDrop();

            Destroy(this.transform.parent.gameObject);

            //destroys (kills) the enemy
            Destroy(gameObject);
            //updates the counter for enemies alive in the room
            SpawnEnemy.enemyCount--;
        }
    }

    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        //checks for the tag on the object it collides with
        if (collisionInfo.collider.tag == "weapon")
        {
            loseHealth();
        }

        //makes player take damage for hitting an enemy
        else if (collisionInfo.collider.tag == "Player")
        {
            damagePlayer();
        }
    }

    // void OnCollisionStay2D(Collision2D collisionInfo)
    // {
    //     if (collisionInfo.collider.tag == "Player")
    //     {

    //     }
    // }

    public void damagePlayer()
    {
         //makes sure the player loses at least 1 health
            if (damage - PlayerInfo.playerDefense <= 0 || PlayerInfo.playerDefense - damage >= 3)
            {
                PlayerInfo.playerHealth -= 2;
            }
            else
            {
                //player loses health equal to the difference in player defense and enemy dmg
                PlayerInfo.playerHealth -= damage - PlayerInfo.playerDefense;
            }
    }

    //picks random number and decides if it should drop an item
    public void itemDrop()
    {
        int shouldDrop = Random.Range(0, 101);

        if (shouldDrop <= 100)
        {
            dropItem.drop = true;
            dropItem.enemyLocation = this.GetComponent<Transform>().position;
        }
    }

    public void loseHealth()
    {
        //checks if enemy has more defense than player damage then only takes 1 dmg otherwise takes more dmg
        if (PlayerInfo.playerDamage + Weapons.currentDmg - defense <= 0)
        {
            health -= 1;
        }

        else 
        {
            health -= PlayerInfo.playerDamage + Weapons.currentDmg - defense;
        }
    }
}
