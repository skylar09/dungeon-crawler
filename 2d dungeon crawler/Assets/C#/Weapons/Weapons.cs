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

    void Awake(){
        ItemDropper.Weapons = this;
        InventoryButtons.Weapons = this;
    }

    // creates the starting weapon
    void Start()
    {
        currentWeapon = bla;
        yourWeapon = Instantiate(prefabs[currentWeapon], player.transform);
        currentDmg = yourWeapon.gameObject.transform.GetChild(0).GetComponent<weaponStats>().damage;
    }

    //changes current weapon by destroying current weapon and then making new weapon
    //updates the player damage based on new weapon
    public void changeWeapon(GameObject wep)
    {
        Quaternion rotation = yourWeapon.transform.rotation;
        Destroy(yourWeapon);
        yourWeapon = Instantiate(wep, PlayerInfo.playerLocation, rotation, player.transform);
        currentDmg = yourWeapon.gameObject.transform.GetChild(0).GetComponent<weaponStats>().damage;
        currentWeapon = findWep(wep.name);
    }

    public int findWep(string name){
        int x = 0;
        for (int i = 0; i < prefabs.Length; i ++){
            if (prefabs[i].name == name){
                x = i;
                break;
            }
        }
        return x;
    }
}
