using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpItem : MonoBehaviour
{
    public static Vector2 location;

    public static bool weaponSwitched = false;
    public static int previousWeapon;

    public static int switchingTo;

    // Update is called once per frame
    void Update()
    {
        //gets the location of this item
        location = this.GetComponent<Transform>().position;

        //changes the current item with the item just dropped
        if (Vector2.Distance(location, PlayerInfo.playerLocation) <= 2)
        {
            if (Input.GetKeyDown("f"))
            {
                previousWeapon = Weapons.currentWeapon;

                Weapons.currentWeapon = switchingTo;
                changeWeapon.changed = true;

                weaponSwitched = true;

                Destroy(gameObject);

                switchingTo = previousWeapon;
            }
        }
    }
}
