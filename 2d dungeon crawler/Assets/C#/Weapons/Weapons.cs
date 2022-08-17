using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public List<GameObject> prefabs = new List<GameObject>();
    List<int> weaponDamages = new List<int>();

    public static int currentDamage;
    public static int currentWeapon = 0;

    public GameObject yourWeapon;

    // Start is called before the first frame update
    void Start()
    {
        yourWeapon = Instantiate(prefabs[currentWeapon], PlayerInfo.playerLocation + new Vector3(.65f, .1f, 0), Quaternion.identity);

        // Remove(list item)

        weaponDamages.Add(1);
        weaponDamages.Add(2);        
        weaponDamages.Add(1);
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

        // weapons[currentWeapon].GetComponent<Transform>().position = PlayerInfo.playerLocation + new Vector3(.65f, .1f, 0);

        currentDamage = weaponDamages[currentWeapon];

        pickUpItem.changed = false;
    }
}
