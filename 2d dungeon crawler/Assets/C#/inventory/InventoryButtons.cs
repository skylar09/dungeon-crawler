using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButtons : MonoBehaviour{
    //the number that this inventory slot is
    public int locationNum;
    public static Weapons Weapons;
    //public GameObject info;

    //changes the item in the item slot with the one you are currently using
    public void ChangeWeapon(){
        //makes sure this doesn't happen unless an item is in the slot
        if(locationNum < InventoryItems.itemNums.Count){
            int weapon = Weapons.currentWeapon;

            Weapons.currentWeapon = InventoryItems.itemNums[locationNum];

            InventoryItems.inventoryLocation = locationNum;
            //changes sprite of inventory slot
            Weapons.player.GetComponent<InventoryItems>().changeCurrent(weapon,Weapons.prefabs[weapon].transform.GetChild(0).gameObject);

            //changes the weapon the player is using to the one that was in the inventory slot
            Weapons.changeWeapon(Weapons.prefabs[Weapons.currentWeapon]);
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
