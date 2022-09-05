using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropItem : MonoBehaviour
{
    public static Vector2 enemyLocation;

    public static bool drop = false;
    public static int weaponNum;

    //all possible items that can be created
    public List<GameObject> Items = new List<GameObject>();
    //items that are created when an enemy drops an item
    public static List<GameObject> createdItems = new List<GameObject>();
    //numbers that correspond to the location in the Items list of dropped items
    public static List<int> createdItemsNumber = new List<int>();

    // Update is called once per frame
    void Update()
    {
        //create a random item
        if (drop == true)
        {
            makeWeapon();
        }

        //makes an uninteractable version of the current weapon
        if (pickUpItem.weaponSwitched == true)
        {
            switchWeapon();
        }
    }

    //makes a weapon
    public void makeWeapon()
    {
        do 
        {
            weaponNum = Random.Range(0, Items.Count);  
<<<<<<< Updated upstream
                            
=======

>>>>>>> Stashed changes
        } while (weaponNum == Weapons.currentWeapon);

        createdItems.Add(Instantiate(Items[weaponNum], enemyLocation, Quaternion.identity));

        createdItemsNumber.Add(weaponNum);
        
        drop = false;
    }

    //creates a weapon when you switch weapons from a weapon on the ground
    public void switchWeapon()
    {
        createdItems.Insert(pickUpItem.closestItem, Instantiate(Items[pickUpItem.groundItem], pickUpItem.newLocation, Quaternion.identity));

        pickUpItem.weaponSwitched = false;
        pickUpItem.buttonPressed = false;
    }
}
