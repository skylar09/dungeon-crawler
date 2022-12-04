using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    //all prefabs of weapons
    public GameObject[] prefabs;

    //the location in prefabs array of current weapon
    public static int currentWeapon = 0;
    //allows changing starting weapon in client DELETE WHEN GAME DONE
    public int bla;

    //if sword is in mid swing or not
    public static bool swordSwung = false;
    //allows player to attack if true
    public static bool canAttack = true;
    //current weapons damage
    public static int currentDmg;

    //the current weapon being used
    public GameObject yourWeapon;
    public GameObject player;

    // creates the starting weapon
    void Start()
    {
        currentWeapon = bla;
        yourWeapon = Instantiate(prefabs[currentWeapon], PlayerInfo.playerLocation, Quaternion.identity);
        currentDmg = yourWeapon.gameObject.transform.GetChild(0).GetComponent<weaponStats>().damage;

        for (int i = 0; i < prefabs.Length - 1; i ++){
            
            dropItem.total += prefabs[i].gameObject.transform.GetChild(0).GetComponent<weaponStats>().dropChance;
        }
    }

    // checks if player has switched their weapon
    void Update()
    {
        if (pickUpItem.changed == true)
        {
            changeWeapon();
        }
    }

    //changes current weapon by destroying current weapon and then makinga new weapon
    //updates the player damage based on new weapon
    public void changeWeapon()
    {
        Quaternion rotation = yourWeapon.transform.rotation;
        Destroy(yourWeapon);
        yourWeapon = Instantiate(prefabs[currentWeapon], PlayerInfo.playerLocation, rotation);
        pickUpItem.changed = false;
        currentDmg = yourWeapon.gameObject.transform.GetChild(0).GetComponent<weaponStats>().damage;
    }
}
