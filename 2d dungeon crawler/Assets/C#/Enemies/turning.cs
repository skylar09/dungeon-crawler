using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turning : MonoBehaviour
{
    public Animator animator;
    public bool turnedRight = false;
    public bool turnedLeft = true;
    
    // Update is called once per frame
    void Update()
    {
        if (PlayerInfo.playerLocation.x >  this.transform.parent.gameObject.transform.position.x && turnedRight != true)
        {
            turnRight();
        }
        else if (PlayerInfo.playerLocation.x <  this.transform.parent.gameObject.transform.position.x && turnedLeft != true)
        {
            turnLeft();
        }
    }

    public void turnRight()
    {
        animator.SetTrigger("playerRight");
        turnedRight = true;
    }

    public void endRight()
    {        
        this.transform.parent.gameObject.GetComponent<Transform>().rotation = new Quaternion(0, 180, 0, 0);
        turnedLeft = false;
    }

    public void turnLeft()
    {
        animator.SetTrigger("playerLeft");
        turnedLeft = true;
    }

    public void endLeft()
    {
        this.transform.parent.gameObject.GetComponent<Transform>().rotation = new Quaternion(0, 0, 0, 0);
        turnedRight = false;
    }
}
