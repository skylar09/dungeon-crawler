 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropItem : MonoBehaviour
{
    public static Vector2 enemyLocation;

    public static bool drop = false;
    public static int weaponNum;

    //all possible items that can be created
    public GameObject[] Items;

    void Start(){
        for(int i = 0; i < Items.Length; i ++){
            Items[i].GetComponent<pickUpItem>().num = i;
        }
    }

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
            weaponNum = Random.Range(0, Items.Length);  
                            
        } while (weaponNum == Weapons.currentWeapon);

        Instantiate(Items[weaponNum], enemyLocation, Quaternion.identity);
        
        drop = false;
    }

    //creates a weapon when you switch weapons from a weapon on the ground
    public void switchWeapon()
    {
       Instantiate(Items[pickUpItem.groundItem], pickUpItem.newLocation, Quaternion.identity);

        pickUpItem.weaponSwitched = false;
        pickUpItem.buttonPressed = false;
    }
}