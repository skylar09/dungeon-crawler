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

    public GameObject yourWeapon;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        yourWeapon = Instantiate(prefabs[currentWeapon], PlayerInfo.playerLocation + new Vector3(.65f, .1f, 0), Quaternion.identity);
<<<<<<< Updated upstream
=======
        //SwordAttack.animator = prefabs[currentWeapon].GetComponent<Animator>();
        yourWeapon.GetComponent<animationSwitcher>().player = player;
        player.GetComponent<SwordAttack>().animator = yourWeapon.GetComponent<Animator>();
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
        if (pickUpItem.changed == true)
        {
            changeWeapon();

            yourWeapon.GetComponent<animationSwitcher>().player = player;
            player.GetComponent<SwordAttack>().animator = yourWeapon.GetComponent<Animator>();
        }
    }

    public void changeWeapon()
    {
        Destroy(yourWeapon);
        
        yourWeapon = Instantiate(prefabs[currentWeapon], PlayerInfo.playerLocation + new Vector3(.65f, .1f, 0), Quaternion.identity);

        currentDamage = weaponDamages[currentWeapon];
        currentKnockback = weaponKnockbacks[currentWeapon];

        pickUpItem.changed = false;
    }
}
