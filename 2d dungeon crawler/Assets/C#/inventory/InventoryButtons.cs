using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButtons : MonoBehaviour
{
    public int locationNum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //changes the item in the item slot with the one you are currently using
    public void ChangeWeapon()
    {
        //makes sure this doesn't happen unless an item is in the slot
        if(locationNum < InventoryItems.itemNums.Count)
        {
            int weapon = Weapons.currentWeapon;

            Weapons.currentWeapon = InventoryItems.itemNums[locationNum];
            pickUpItem.changed = true;

            InventoryItems.inventoryLocation = locationNum;
            InventoryItems.replaceItem = weapon;
            InventoryItems.changeUIWeapon = true;
        }
        
    }
}
