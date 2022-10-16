using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponParent : MonoBehaviour
{
    public GameObject currentWeapon;
    public GameObject player;

    public void Update()
    {

        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float angle = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);

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

        Vector2 scale = transform.localScale;
        if (difference.x < 0)
        {
            scale.y = -1;
        }
        else if (difference.x > 0)
        {
            scale.y = 1;
        }
        transform.localScale = scale;
    }
}
