using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public GameObject[] prefabs;

    public static int currentWeapon = 0;
    public int bla;

    public static bool swordSwung = false;
    public static bool canAttack = true;

    public GameObject yourWeapon;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        currentWeapon = bla;
        yourWeapon = Instantiate(prefabs[currentWeapon], PlayerInfo.playerLocation + new Vector3(.65f, .1f, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (pickUpItem.changed == true)
        {
            changeWeapon();
        }
    }

    public void changeWeapon()
    {
        Destroy(yourWeapon);
        yourWeapon = Instantiate(prefabs[currentWeapon], PlayerInfo.playerLocation + new Vector3(.65f, .1f, 0), Quaternion.identity);
        pickUpItem.changed = false;
        PlayerInfo.playerDamage = yourWeapon.gameObject.transform.GetChild(0).GetComponent<weaponStats>().damage;
    }
}
