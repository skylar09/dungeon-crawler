using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class stabAttack : MonoBehaviour
{
    public Weapons WeaponsScript;
    public GameObject refrence;

    // Start is called before the first frame update
    void Start()
    {
        WeaponsScript = refrence.GetComponent<Weapons>();
        WeaponsScript.yourWeapon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            //if left click
            if (Input.GetMouseButtonDown(0) && Weapons.canAttack == true)
            {
                activateWeapon();
            }
        }
    }

    public void activateWeapon()
    {
        refrence.GetComponent<Weapons>().yourWeapon = gameObject;
    }
}
