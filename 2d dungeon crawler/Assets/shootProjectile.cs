using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootProjectile : MonoBehaviour
{
    public float dist;
    float posX, posY;
    public GameObject projectile;
    
    public void spawnProjectile(){
        posX = this.transform.parent.gameObject.transform.position.x + (weaponRotate.cos * dist);
        posY = this.transform.parent.gameObject.transform.position.y + (weaponRotate.sin * dist);
        GameObject bla = Instantiate(projectile, new Vector3(posX, posY, 0), Quaternion.AngleAxis(weaponRotate.angle, Vector3.forward));
    }
}
