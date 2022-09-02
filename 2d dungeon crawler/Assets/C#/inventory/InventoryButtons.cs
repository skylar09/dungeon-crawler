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

    public void ChangeWeapon()
    {
        int weapon = Weapons.currentWeapon;

        Weapons.currentWeapon = InventoryItems.itemNums[locationNum];
        pickUpItem.changed = true;

        InventoryItems.inventoryLocation = locationNum;
        InventoryItems.replaceItem = weapon;
        InventoryItems.changeUIWeapon = true;
    }
}
