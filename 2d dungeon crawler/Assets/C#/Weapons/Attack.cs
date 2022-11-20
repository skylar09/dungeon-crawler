using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class Attack : MonoBehaviour
{
    //animator of weapon
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        //stops player from being able to attack when inventory is open (or other thing is open in future)
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            //if left click
            if (Input.GetMouseButtonDown(0) && Weapons.canAttack == true)
            {
                attack();
            }
        }
    }

    //causes weapon attack animation to run and updates variables
    public void attack()
    {
        Weapons.swordSwung = true;
        Weapons.canAttack = false;
        animator.SetTrigger("attack");
    }

    //this is used to wait a certain amount of time before doing something
    // IEnumerator Wait()
    // {
    //     yield return new WaitForSecondsRealtime(1/2);
        
    // }
}