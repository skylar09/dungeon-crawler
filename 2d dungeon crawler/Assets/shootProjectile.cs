using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootProjectile : MonoBehaviour
{
    public float dist;
    public static float cos, sin;
    float posX, posY;
    public GameObject projectile;
    
    public void spawnProjectile(){
        cos = Mathf.Cos(weaponRotate.angle * Mathf.PI / 180);
        sin = Mathf.Sin(weaponRotate.angle * Mathf.PI / 180);

        posX = this.transform.parent.gameObject.transform.position.x + (cos * dist);
        posY = this.transform.parent.gameObject.transform.position.y + (sin * dist);
        GameObject bla = Instantiate(projectile, new Vector3(posX, posY, 0), Quaternion.AngleAxis(weaponRotate.angle, Vector3.forward));
    }
}
