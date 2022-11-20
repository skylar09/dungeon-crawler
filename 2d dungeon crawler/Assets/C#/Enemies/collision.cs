using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public int health;
    public int damage;
    public int defense;
    public int deathGold;
    public float moveSpeed;

    void Awake()
    {
        health *= pauseMenu.whichScene;
    }

    void Start()
    {
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

            //destroys (kills) the enemy
            Destroy(gameObject);

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

        if (shouldDrop <= 10)
        {
            dropItem.drop = true;
            dropItem.enemyLocation = this.GetComponent<Transform>().position;
        }
    }

    public void loseHealth()
    {
        if (PlayerInfo.playerDamage - defense <= 0)
        {
            health -= 1;
        }

        else 
        {
            health -= PlayerInfo.playerDamage - defense;
        }
    }
}
