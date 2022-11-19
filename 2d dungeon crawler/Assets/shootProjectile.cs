using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootProjectile : MonoBehaviour
{
    public float dist;
    float posX, posY, rotate;
    Vector3 angle;
    int num;
    public GameObject projectile;
    
    public void spawnProjectile(){
        angle = this.transform.parent.gameObject.transform.rotation.eulerAngles;

        if (angle.y == 180){
            angle.z = 90 - angle.z;
        }
        else if (angle.x == 180){
            angle.z = 360 + angle.z;
        }
        else
            angle.z += 90;

        if (weaponRotate.mouse_pos.x > 0){
            rotate = 0;
            //Debug.Log(weaponRotate.mouse_pos.x);
        }
        else{
            rotate = 180;
            //Debug.Log(weaponRotate.mouse_pos.x);
        }

        posX = this.transform.parent.gameObject.transform.position.x + (Mathf.Cos(angle.z * Mathf.PI / 180) * dist);
        posY = this.transform.parent.gameObject.transform.position.y + (Mathf.Sin(angle.z * Mathf.PI / 180) * dist);
        Instantiate(projectile, new Vector3(posX, posY, 0), new Quaternion(0, rotate, 0, 0));
        Debug.Log(new Vector3(posX, posY, 0));
    }
}
