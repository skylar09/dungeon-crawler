using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpItem : MonoBehaviour
{
    public static Vector2 location;

    public static Vector2 newLocation;

    public static bool weaponSwitched = false;
    public static int groundItem;

    public static int closestItem;

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
                if (dropItem.createdItems.Count > 1)
                {
                    for (int i = 0; i < dropItem.createdItems.Count - 1; i++)
                    {
                        float distance1 = Vector2.Distance(dropItem.createdItems[i].GetComponent<Transform>().position, PlayerInfo.playerLocation);
                        float distance2 = Vector2.Distance(dropItem.createdItems[i + 1].GetComponent<Transform>().position, PlayerInfo.playerLocation);

                        if (distance1 < distance2)
                        {
                            closestItem = i;
                        }

                        else 
                        {
                            closestItem = i + 1;
                        }
                    }
                }

                else
                {
                    closestItem = 0;
                }

                int pickedUp = groundItem;

                groundItem = Weapons.currentWeapon;

                Weapons.currentWeapon = pickedUp;
                changeWeapon.changed = true;

                weaponSwitched = true;

                newLocation = dropItem.createdItems[closestItem].GetComponent<Transform>().position;

                Destroy(dropItem.createdItems[closestItem]);
                // Debug.Log("in list " + dropItem.createdItems.Count);
                Debug.Log("closest " + closestItem);

                dropItem.createdItems.RemoveAt(closestItem);
            }
        }
    }
}
