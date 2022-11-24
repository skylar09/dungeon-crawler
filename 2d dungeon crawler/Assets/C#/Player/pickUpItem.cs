using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpItem : MonoBehaviour
{
    //these 3 used for switching weapons on the ground
    public static Vector2 newLocation;
    public static int groundItem;
    public int num;

    public static bool weaponSwitched = false;
    public static bool changed = false;
    public static bool buttonPressed = false;

    public static GameObject closestWep;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f") && buttonPressed == false)
        {
            Vector2 location = this.transform.position;
            float dist = Vector2.Distance(location, PlayerInfo.playerLocation);

            //changes the current item with the item just dropped
            if (dist <= 2)
            {
                buttonPressed = true;
                closest(dist);     
                if (this.gameObject == closestWep){
                    pickUpCurrent();
                }                  
            }
        }

        if (Input.GetKeyDown("g") && buttonPressed == false)
        {
            Vector2 location = this.transform.position;
            float dist = Vector2.Distance(location, PlayerInfo.playerLocation);

            //changes the current item with the item just dropped
            if (dist <= 2)
            {
                buttonPressed = true;
                closest(dist);     
                if (this.gameObject == closestWep){
                    addInventory();
                }                  
            }
        }
    }

    //gets the closest item on the ground
    public void closest(float dist)
    {          
        if (closestWep == null){
            closestWep = this.gameObject;
            return;
        }
        float dist2 = Vector2.Distance(closestWep.transform.position, PlayerInfo.playerLocation);
        if (dist < dist2){
            closestWep = this.gameObject;
        }
    }

    //changes the current item with the item just dropped
    public void pickUpCurrent()
    {
        groundItem = Weapons.currentWeapon;

        Weapons.currentWeapon = closestWep.GetComponent<pickUpItem>().num;

        changed = true;
        weaponSwitched = true;

        newLocation = closestWep.transform.position;

        Destroy(closestWep.gameObject);

        Weapons.canAttack = true;
        Weapons.swordSwung = false;
    }

    //adds the closest item to your inventory
    public void addInventory()
    {
        InventoryItems.replaceItem = closestWep.GetComponent<pickUpItem>().num;
        Destroy(closestWep.gameObject);
        
        InventoryItems.newItem = true;

        changed = true;
    }
}
