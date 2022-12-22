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
    public float immunityTime;
    private bool canDamage = true;
    public static ItemDropper ItemDropper;

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

    void OnCollisionStay2D (Collision2D collisionInfo)
    {
        //makes player take damage for hitting an enemy
        if (collisionInfo.collider.tag == "Player")
        {
            damagePlayer();
            collisionInfo.gameObject.GetComponent<SimpleFlash>().Flash();
            collisionInfo.gameObject.GetComponent<invulnerability>().playerImmunityFrames();            
        }
    }
    void OnTriggerStay2D (Collider2D collisionInfo){
        //checks for the tag on the object it collides with
        if (collisionInfo.tag == "weapon"  && Weapons.canAttack == false)
        {
            if (canDamage == true){
                loseHealth(PlayerInfo.playerDamage + Weapons.currentDmg);
                this.GetComponent<SimpleFlash>().Flash();
                canDamage = false;
                StartCoroutine(immunityFrames(immunityTime));
            }
        }
    }

    void OnCollisionExit2D (Collision2D collisionInfo){
        this.transform.parent.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
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
            PlayerInfo.playerHealth -= 1;
        }
        else
        {
            //player loses health equal to the difference in player defense and enemy dmg
            PlayerInfo.playerHealth -= damage - PlayerInfo.playerDefense;
        }
    }

    public void loseHealth(int dmg)
    {
        //checks if enemy has more defense than player damage then only takes 1 dmg otherwise takes more dmg
        if (dmg - defense <= 0)
        {
            health -= 1;
        }

        else 
        {
            health -= dmg - defense;
        }

        //when the enemy is dead
        if (health <= 0)
        {
            killThis();
        }
    }

    private void killThis(){
        //gives the player gold
        PlayerInfo.gold += deathGold;
        PlayerInfo.ammo += 2;

        //updates the counter for enemies alive in the room
        SpawnEnemy.enemyCount--;
        statTracker.enemiesKilled ++;

        //has chance to drop item when last enemy dies
        if (SpawnEnemy.enemyCount == 0)
            ItemDropper.itemDrop(this.transform.parent.position);

        Destroy(this.transform.parent.gameObject);

        //destroys (kills) the enemy
        Destroy(gameObject);
    }

    IEnumerator immunityFrames(float immuneTime){
        yield return new WaitForSecondsRealtime(immuneTime);
        canDamage = true;
    }
}