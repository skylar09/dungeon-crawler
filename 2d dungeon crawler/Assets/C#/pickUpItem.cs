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

    // Update is called once per frame
    void Update()
    {
        //gets the location of this item
        location = this.GetComponent<Transform>().position;

        //changes the current item with the item just dropped
        if (Vector2.Distance(location, PlayerInfo.playerLocation) <= 2 && Input.GetKeyDown("f"))
        {
            pickUpCurrent();            
        }

        if (Vector2.Distance(location, PlayerInfo.playerLocation) <= 2 && Input.GetKeyDown("g"))
        {
            addInventory();            
        }
    }

    public void closest()
    {
        if (dropItem.createdItems.Count > 1)
        {
            closestItem = 0;
            
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

        else
        {
            closestItem = 0;
        }
    }

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

    public void addInventory()
    {
        closest();
        
        InventoryItems.items.Add(dropItem.createdItems[closestItem]);
        // Debug.Log(InventoryItems.items.Count);

        Destroy(dropItem.createdItems[closestItem]);
        dropItem.createdItems.RemoveAt(closestItem);

        InventoryItems.newItem = true;
    }
}
