using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponParent : MonoBehaviour
{
    public GameObject currentWeapon;

    public void Update()
    {
        Vector3 mouse_pos = Input.mousePosition;
        mouse_pos.z = -20;
        Vector3 object_pos = Camera.main.WorldToScreenPoint(transform.position);
        mouse_pos.x = mouse_pos.x - object_pos.x;
        mouse_pos.y = mouse_pos.y - object_pos.y;
        float angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        if (angle > 0 && angle < 180)
        {
            currentWeapon.GetComponent<SpriteRenderer>().sortingOrder = 4;
        }
        else
        {
            currentWeapon.GetComponent<SpriteRenderer>().sortingOrder = 5;
        }
    }
}
