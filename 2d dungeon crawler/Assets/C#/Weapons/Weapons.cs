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
    }

    // Update is called once per frame
    void Update()
    {
        if (changeWeapon.changed == true)
        {
            weaponCurrent = weapons[currentWeapon];
        }
    }
}
