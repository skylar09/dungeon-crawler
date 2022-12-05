using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nearbyAttackAnim : MonoBehaviour
{
    public Animator animator;
    public double distance;

    void Update()
    {
        //if within range of player changes animation otherwise change to dif animation
        if (Vector2.Distance(transform.position, PlayerInfo.playerLocation) <= distance)
        {
            animator.SetBool("playerNearby", true);
        }
        else
        {
            animator.SetBool("playerNearby", false);
        }
    }
}
