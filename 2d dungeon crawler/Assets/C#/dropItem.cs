using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropItem : MonoBehaviour
{
    public static Vector2 enemyLocation;

    public static bool drop = false;
    public static int weaponNum;

    public List<GameObject> Items = new List<GameObject>();

    public static List<GameObject> createdItems = new List<GameObject>();

    // Update is called once per frame
    void Update()
    {
        //create a random item
        if (drop == true)
        {
            do 
            {
                weaponNum = Random.Range(0, Items.Count);  
                              
            } while (weaponNum == Weapons.currentWeapon);

            pickUpItem.groundItem = weaponNum;

            createdItems.Add(Instantiate(Items[weaponNum], enemyLocation, Quaternion.identity));
            
            drop = false;
        }

        //makes an uninteractable version of the current weapon
        if (pickUpItem.weaponSwitched == true)
        {
            createdItems.Add(Instantiate(Items[pickUpItem.groundItem], pickUpItem.newLocation, Quaternion.identity));

            pickUpItem.weaponSwitched = false;
        }
    }
}
