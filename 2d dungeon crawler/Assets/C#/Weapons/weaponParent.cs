using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class weaponParent : MonoBehaviour
{
    public GameObject currentWeapon;
    public GameObject player;

    public void FixedUpdate()
    {

        //Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - player.transform.position;
        //Vector2 difference = SwordAttack.worldPosition.Normalize();

        float distX = this.transform.position.x - SwordAttack.worldPosition.x;
        float distY = this.transform.position.y - SwordAttack.worldPosition.y;
        //distZ = Math.Sqrt((distX * distX) + (distY * distY));

        float angle = Mathf.Atan2(distY, distX) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);

        float x = Mathf.Cos(angle) * .1529705854f;
        float y = Mathf.Sin(angle) * .1529705854f;
        currentWeapon.GetComponent<Transform>().position = this.transform.position - new Vector3(x, y, 0);
        //Debug.Log(angle);

        if (angle > 0 && angle < 180)
        {
            currentWeapon.GetComponent<SpriteRenderer>().sortingOrder = 3;
            player.GetComponent<Transform>().rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            currentWeapon.GetComponent<SpriteRenderer>().sortingOrder = 5;
            player.GetComponent<Transform>().rotation = new Quaternion(0, 0, 0, 0);
            //transform.position = PlayerInfo.playerLocation + new Vector3(.15f, 0, 0);
        }

        // Vector2 scale = transform.localScale;
        // if (difference.x < 0)
        // {
        //     scale.y = -1;
        // }
        // else if (difference.x > 0)
        // {
        //     scale.y = 1;
        // }
        //transform.localScale = scale;
    }
}
