using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nearbyAttackAnim : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        if (this.GetComponent<enemyMovement>().meleeAttack == true)
        {
            //this.GetComponent<enemyMovement>().canMove = false;
            animator.SetBool("playerNearby", true);
        }
        else 
        {
            //this.GetComponent<enemyMovement>().canMove = true;
            animator.SetBool("playerNearby", false);
        }
    }
    
}
