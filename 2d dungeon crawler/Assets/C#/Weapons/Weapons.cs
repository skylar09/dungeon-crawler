using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    //all interactable weapons 
    public List<GameObject> prefabs = new List<GameObject>();
    //all weapon damages that correspond to the weapon in the same location in other lists
    public List<int> weaponDamages = new List<int>();
    //all weapon knockbacks that correspond to the weapon in the same location in other lists
    public List<int> weaponKnockbacks = new List<int>();

    public static int currentDamage;
    public static int currentWeapon = 0;
    public static int currentKnockback;

    public static bool swordSwung = false;
    public static bool canAttack = true;

    public GameObject yourWeapon;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        yourWeapon = Instantiate(prefabs[currentWeapon], PlayerInfo.playerLocation + new Vector3(.65f, .1f, 0), Quaternion.identity);
        player.GetComponent<SwordAttack>().animator = yourWeapon.GetComponent<Animator>();
        yourWeapon.GetComponent<animationSwitcher>().player = player;
    }

    // Update is called once per frame
    void Update()
    {
        if (pickUpItem.changed == true)
        {
            changeWeapon();

            player.GetComponent<SwordAttack>().animator = yourWeapon.GetComponent<Animator>();
            yourWeapon.GetComponent<animationSwitcher>().player = player;
        }

        if (!yourWeapon.GetComponent<Animator>())
        {
            player.GetComponent<SwordAttack>().animator = yourWeapon.GetComponent<Animator>();
            player.GetComponent<SwordAttack>().restartVariables();
        }
    }

    public void changeWeapon()
    {
        Destroy(yourWeapon);
        
        yourWeapon = Instantiate(prefabs[currentWeapon], PlayerInfo.playerLocation + new Vector3(.65f, .1f, 0), Quaternion.identity);

        // weapons[currentWeapon].GetComponent<Transform>().position = PlayerInfo.playerLocation + new Vector3(.65f, .1f, 0);

        currentDamage = weaponDamages[currentWeapon];
        currentKnockback = weaponKnockbacks[currentWeapon];

        pickUpItem.changed = false;
        player.GetComponent<SwordAttack>().restartVariables();
    }
}
