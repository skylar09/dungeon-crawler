using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golgoblinAnimations : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        if (this.GetComponent<enemyMovement>().closeTo != true)
        {
            this.GetComponent<enemyMovement>().canMove = false;
            animator.SetBool("playerNearby", false);
        }
        else 
        {
            this.GetComponent<enemyMovement>().canMove = true;
            animator.SetBool("playerNearby", true);
        }
    }
    
}
