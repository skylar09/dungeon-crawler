using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropItem : MonoBehaviour
{
    public static Vector2 enemyLocation;
    public Vector2 itemLocation;

    public static bool drop = false;
    public static int weaponNum;

    public List<GameObject> Items = new List<GameObject>();

    // Update is called once per frame
    void Update()
    {
        //gets the location of the item
        itemLocation = pickUpItem.location;

        //create a random item
        if (drop == true)
        {
            weaponNum = Random.Range(0, Items.Count);

            Instantiate(Items[weaponNum], enemyLocation, Quaternion.identity);
            
            drop = false;
        }

        //makes a uninteractable version of the current weapon
        if (pickUpItem.weaponSwitched == true)
        {
            Instantiate(Items[pickUpItem.previousWeapon], itemLocation, Quaternion.identity);

            pickUpItem.weaponSwitched = false;
        }
    }
}
