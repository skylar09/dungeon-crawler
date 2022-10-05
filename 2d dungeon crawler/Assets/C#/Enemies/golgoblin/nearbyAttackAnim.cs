using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nearbyAttackAnim : MonoBehaviour
{
    public Animator animator;
    public bool meleeAttack = false;
    public double distance;

    void Update()
    {
        if (meleeAttack == true)
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

    void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, PlayerInfo.playerLocation) < distance)
        {
            meleeAttack = true;
        }
        else
        {
            meleeAttack = false;
        }
    }
    
}
