using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class SwordAttack : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            //if left click
            if (Input.GetMouseButtonDown(0) && Weapons.canAttack == true)
            {
                attack();
            }
        }
    }

    public void attack()
    {
        Weapons.swordSwung = true;
        Weapons.canAttack = false;
        animator.SetTrigger("attack");
        resetVariables();
    }

    //resets rotation, swordSwung, canAttack, and turns weapon off
    public void resetVariables()
    {
        Weapons.canAttack = true;
        Weapons.swordSwung = false;
    }

    //this is used to wait a certain amount of time before doing something
    // IEnumerator Wait()
    // {
    //     yield return new WaitForSecondsRealtime(1/2);
        
    // }
}