using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpItem : MonoBehaviour
{
    public static Vector2 location;

    public static Vector2 newLocation;

    public static int groundItem;
    public static int closestItem;

    public static bool weaponSwitched = false;
    public static bool changed = false;
    public static bool buttonPressed = false;

    // Update is called once per frame
    void Update()
    {
        //gets the location of this item
        location = this.GetComponent<Transform>().position;

        //changes the current item with the item just dropped
        if (Vector2.Distance(location, PlayerInfo.playerLocation) <= 2 && Input.GetKeyDown("f") && buttonPressed == false)
        {
            buttonPressed = true;
            pickUpCurrent();
                        
        }
        //adds the closest item to your inventory
        if (Vector2.Distance(location, PlayerInfo.playerLocation) <= 2 && Input.GetKeyDown("g") && buttonPressed == false)
        {
            buttonPressed = true;
            addInventory();            
        }
    }

    //gets the closest item on the ground
    public void closest()
    {
        closestItem = 0;

        if (dropItem.createdItems.Count > 1)
        {            
            for (int i = 1; i < dropItem.createdItems.Count; i++)
            {
                float distance1 = Vector2.Distance(dropItem.createdItems[closestItem].GetComponent<Transform>().position, PlayerInfo.playerLocation);
                float distance2 = Vector2.Distance(dropItem.createdItems[i].GetComponent<Transform>().position, PlayerInfo.playerLocation);
                // Debug.Log("1 " + distance1 + " 2 " + distance2);
                
                if (distance1 > distance2)
                {
                    closestItem = i;
                }
            }
        }
    }

    //changes the current item with the item just dropped
    public void pickUpCurrent()
    {
        closest();

        groundItem = Weapons.currentWeapon;

        Weapons.currentWeapon = dropItem.createdItemsNumber[closestItem];
        dropItem.createdItemsNumber[closestItem] = groundItem;

        changed = true;
        weaponSwitched = true;

        newLocation = dropItem.createdItems[closestItem].GetComponent<Transform>().position;

        Destroy(dropItem.createdItems[closestItem]);

        dropItem.createdItems.RemoveAt(closestItem);
    }

    //adds the closest item to your inventory
    public void addInventory()
    {
        closest();

        Destroy(dropItem.createdItems[closestItem]);
        dropItem.createdItems.RemoveAt(closestItem);

        InventoryItems.newItem = true;

        changed = true;
    }
}
