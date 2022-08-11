using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public List<GameObject> weapons = new List<GameObject>();
    List<int> weaponDamages = new List<int>();

    public static int currentDamage;
    public static int currentWeapon = 0;

    public GameObject weaponCurrent;

    // Start is called before the first frame update
    void Start()
    {
        weaponDamages.Add(1);
        weaponDamages.Add(2);        
        weaponDamages.Add(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (changeWeapon.changed == true)
        {
            weapons[currentWeapon].SetActive(false);

            weaponCurrent = weapons[currentWeapon];
            weapons[currentWeapon].GetComponent<Transform>().position = PlayerInfo.playerLocation + new Vector3(.65f, .1f, 0);

            currentDamage = weaponDamages[currentWeapon];
            Debug.Log(currentDamage);

            changeWeapon.changed = false;
        }
    }
}
