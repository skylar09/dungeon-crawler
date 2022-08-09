using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public List<GameObject> weapons = new List<GameObject>();
    List<int> weaponDamages = new List<int>();

    public static int currentDamage;
    public int currentWeapon = 0;

    // Start is called before the first frame update
    void Start()
    {
        weaponDamages.Add(1);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
