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
            Debug.Log("right");
            Debug.Log("player " + PlayerInfo.playerLocation.x);
            Debug.Log("enemy " + transform.position.x);
            turnRight();
        }
        else if (PlayerInfo.playerLocation.x < transform.position.x && turnedLeft != true)
        {
            Debug.Log("left");
            Debug.Log("player " + PlayerInfo.playerLocation.x);
            Debug.Log("enemy " + transform.position.x);
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
