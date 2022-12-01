using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class shootProjectile : MonoBehaviour
{
    //distance from center of player to where bullet should spawn and how long until can be fired again
    public float dist, fireSpeed;
    //x,y cords of where projectile spawns
    float posX, posY;
    //the thing that will be shot out of gun
    public GameObject projectile;
    
    void Update()
    {
        //stops player from being able to attack when inventory is open (or other thing is open in future)
        if (!EventSystem.current.IsPointerOverGameObject()){
            //if left click
            if (Input.GetMouseButtonDown(0) && Weapons.canAttack == true && PlayerInfo.ammo > 0)
            {
                spawnProjectile();
                PlayerInfo.ammo --;
                this.GetComponent<ammoTracker>().updateAmmo();
                
            }
        }
    }

    //spawns projectile at a certain spot with a certain z rotation (points to mouse)
    public void spawnProjectile(){
        Weapons.canAttack = false; 
        posX = this.transform.parent.gameObject.transform.position.x + (weaponRotate.cos * dist);
        posY = this.transform.parent.gameObject.transform.position.y + (weaponRotate.sin * dist);
        GameObject bla = Instantiate(projectile, new Vector3(posX, posY, 0), Quaternion.AngleAxis(weaponRotate.angle, Vector3.forward));

        StartCoroutine(Wait());
    }

    //waits for n seconds then sets canAttack to true
    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(fireSpeed);
        Weapons.canAttack = true;        
    }
}
