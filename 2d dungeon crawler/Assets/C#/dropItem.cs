using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropItem : MonoBehaviour
{
    public static Vector2 enemyLocation;

    public static bool drop = false;
    public static int weaponNum = 0;

    public List<GameObject> Items = new List<GameObject>();

    // Update is called once per frame
    void Update()
    {
        //create a random item
        if (drop == true)
        {
            while (weaponNum == Weapons.currentWeapon)
            {
                weaponNum = Random.Range(0, Items.Count);                
            }

            pickUpItem.switchingTo = weaponNum;

            Instantiate(Items[weaponNum], enemyLocation, Quaternion.identity);
            
            drop = false;
        }

        //makes a uninteractable version of the current weapon
        if (pickUpItem.weaponSwitched == true)
        {
            Instantiate(Items[pickUpItem.previousWeapon], pickUpItem.location, Quaternion.identity);

            pickUpItem.weaponSwitched = false;
        }
    }
}
