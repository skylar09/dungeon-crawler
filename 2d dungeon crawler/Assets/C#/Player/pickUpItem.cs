using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpItem : MonoBehaviour
{
    
public static GameObject closest;
    public static int groundItem;
    public static int closestItem;

    public static bool weaponSwitched = false;
    public static bool changed = false;
    public static bool buttonPressed = false;

    // Update is called once per frame
    void Update()
    {
        float dist = closest.GetComponent<pickUpItem>().getDist();
        if (this != closest){
            if (dist > this.getDist()){}
                //closest = this.GameObject;
        }
        else if (dist <= 2){
            if (Input.GetKeyDown("f") && buttonPressed == false){
                buttonPressed = true;
                pickUp();
            }
        }
    }

    public float getDist(){
        return Vector2.Distance(this.transform.position, PlayerInfo.playerLocation);
    }

    private void pickUp(){
        groundItem = Weapons.currentWeapon;

        Weapons.currentWeapon = dropItem.createdItemsNumber[closestItem];
        dropItem.createdItemsNumber[closestItem] = groundItem;

        changed = true;
        weaponSwitched = true;

        //newLocation = dropItem.createdItems[closestItem].GetComponent<Transform>().position;

        Destroy(dropItem.createdItems[closestItem]);

        dropItem.createdItems.RemoveAt(closestItem);
    }
}
