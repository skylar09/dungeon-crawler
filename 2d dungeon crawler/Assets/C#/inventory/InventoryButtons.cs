using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButtons : MonoBehaviour{
    //the number that this inventory slot is
    public int locationNum;
    //public GameObject info;

    //changes the item in the item slot with the one you are currently using
    public void ChangeWeapon(){
        //makes sure this doesn't happen unless an item is in the slot
        if(locationNum < InventoryItems.itemNums.Count){
            int weapon = Weapons.currentWeapon;

            Weapons.currentWeapon = InventoryItems.itemNums[locationNum];

            InventoryItems.inventoryLocation = locationNum;
            InventoryItems.replaceItem = weapon;
            InventoryItems.changeUIWeapon = true;
        }
    }

    public void hoverOver(){
        //makes sure this doesn't happen unless an item is in the slot
        if(locationNum < InventoryItems.itemNums.Count){
            //info.SetActive(true);
        }
    }

    public void endHover(){
        //makes sure this doesn't happen unless an item is in the slot
        if(locationNum < InventoryItems.itemNums.Count){
            //info.SetActive(false);
        }
    }
}
