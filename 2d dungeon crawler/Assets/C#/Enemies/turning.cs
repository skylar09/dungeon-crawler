using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turning : MonoBehaviour
{
    public Animator animator;
    private bool turnedRight = false;
    private bool turnedLeft = true;
    
    // Update is called once per frame
    void Update()
    {
        if (PlayerInfo.playerLocation.x > transform.position.x && turnedRight != true)
        {
            turnRight();
        }
        else if (PlayerInfo.playerLocation.x < transform.position.x && turnedLeft != true)
        {
            turnLeft();
        }
    }

    public void turnRight()
    {
        animator.SetBool("playerRight", true);
        turnedRight = true;
    }

    public void endRight()
    {
        animator.SetBool("playerRight", false);
        turnedLeft = false;
    }

    public void turnLeft()
    {
        
        animator.SetBool("playerLeft", true);
        turnedLeft = true;
    }

    public void endLeft()
    {
        animator.SetBool("playerLeft", false);
        turnedRight = false;
    }
}
