using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponRotate : MonoBehaviour
{
    Vector3 mouse_pos;
    Transform target; //Assign to the object you want to rotate
    public static Vector3 object_pos;
    float angle;
 
    public void Start()
    {
        target = this.transform;
    }

    public void Update()
    {
        if (Weapons.swordSwung != true)
        {
             mouse_pos = Input.mousePosition;
            //mouse_pos.z = 10; //The distance between the camera and object
            object_pos = Camera.main.WorldToScreenPoint(target.position);
            mouse_pos.x = mouse_pos.x - object_pos.x;
            mouse_pos.y = mouse_pos.y - object_pos.y;
            angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));

            if (mouse_pos.x > 0)
                transform.rotation = Quaternion.Euler(new Vector3(0, 180, 90 - angle));
            else
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
        }

        // float posX = PlayerInfo.playerLocation.x - Mathf.Cos(angle) * .15f;
        // float posY = PlayerInfo.playerLocation.y - Mathf.Sin(angle) * .15f;

        // transform.position = new Vector3(posX, posY, 0);
        transform.position = PlayerInfo.playerLocation;
    } 
}
