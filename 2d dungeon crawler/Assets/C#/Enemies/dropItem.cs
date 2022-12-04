 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropItem : MonoBehaviour
{
    public static Vector2 enemyLocation;

    public static bool drop = false;
    public static int weaponNum;
    public int total = 0;

    //all possible items that can be created
    public GameObject[] Items;

    void Start(){
        for(int i = 0; i < Items.Length; i ++){
            Items[i].GetComponent<pickUpItem>().num = i;
        }

        for (int i = 0; i < Items.Length - 1; i ++){
            total += Items[i].GetComponent<weaponStats>().dropChance;
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
        int chance = Random.Range(0, total + 1);
        do {    
            for (int i = 0; i < Items.Length - 1; i ++){
                if (chance <= Items[i].GetComponent<weaponStats>().dropChance){
                    weaponNum = i;
                    break;
                }
                else
                    chance -= Items[i].GetComponent<weaponStats>().dropChance;
            }     
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