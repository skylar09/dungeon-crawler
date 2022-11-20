using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class shootProjectile : MonoBehaviour
{
    public float dist, fireSpeed;
    float posX, posY;
    public GameObject projectile;
    
    void Update()
    {
        if (!EventSystem.current.IsPointerOverGameObject()){
            //if left click
            if (Input.GetMouseButtonDown(0) && Weapons.canAttack == true)
            {
                spawnProjectile();
            }
        }
    }

    public void spawnProjectile(){
        Weapons.canAttack = false; 
        posX = this.transform.parent.gameObject.transform.position.x + (weaponRotate.cos * dist);
        posY = this.transform.parent.gameObject.transform.position.y + (weaponRotate.sin * dist);
        GameObject bla = Instantiate(projectile, new Vector3(posX, posY, 0), Quaternion.AngleAxis(weaponRotate.angle, Vector3.forward));

        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(fireSpeed);
        Weapons.canAttack = true;        
    }
}
