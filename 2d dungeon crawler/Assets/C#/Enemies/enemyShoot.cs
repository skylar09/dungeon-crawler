using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShoot : MonoBehaviour{
    //distance from center of enemy to where bullet should spawn and how long until can be fired again
    public float centerDist, distance, fireSpeed;
    //x,y cords of where projectile spawns
    float posX, posY;
    //the thing that will be shot
    public GameObject projectile;
    private bool canAttack = true;
    public static float angle = 0f;

    void Update(){
        if (Vector2.Distance(transform.position, PlayerInfo.playerLocation) <= distance && canAttack == true){
            spawnProjectile();
        }
    }

    //spawns projectile at a certain spot with a certain z rotation (points to mouse)
    public void spawnProjectile(){
        //posX = this.transform.parent.gameObject.transform.position.x + (weaponRotate.cos * centerDist);
        //posY = this.transform.parent.gameObject.transform.position.y + (weaponRotate.sin * centerDist);
        Vector2 dist = PlayerInfo.playerLocation - transform.parent.position;
        angle = Mathf.Atan2(dist.y, dist.x) * Mathf.Rad2Deg;
        GameObject bla = Instantiate(projectile, transform.parent.position, Quaternion.AngleAxis(angle, Vector3.forward));
        canAttack = false; 
        StartCoroutine(Wait());
    }

    //waits for n seconds then sets canAttack to true
    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(fireSpeed);
        canAttack = true;        
    }
}
