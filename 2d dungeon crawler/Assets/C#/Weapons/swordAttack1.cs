using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordAttack1 : MonoBehaviour
{
    Vector3 mouse_pos;
    Transform target; //Assign to the object you want to rotate
    Vector3 object_pos;
    float angle;
 
    public void Start()
    {
        target = this.transform;
    }

    public void Update()
    {
        transform.position = PlayerInfo.playerLocation;

        mouse_pos = Input.mousePosition;
        mouse_pos.z = 10; //The distance between the camera and object
        object_pos = Camera.main.WorldToScreenPoint(target.position);
        mouse_pos.x = mouse_pos.x - object_pos.x;
        mouse_pos.y = mouse_pos.y - object_pos.y;
        angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
        Debug.Log(angle);
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
    }
}
