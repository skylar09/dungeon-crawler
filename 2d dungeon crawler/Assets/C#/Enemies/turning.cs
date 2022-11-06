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
            turn();
        }
        else if (PlayerInfo.playerLocation.x <  this.transform.parent.gameObject.transform.position.x && turnedLeft != true)
        {
            turn();
        }
    }

    public void turn()
    {
        animator.SetTrigger("turn");

        if (turnedRight == true)
            {
                turnedRight = false;
                turnedLeft = true;
            }
        else
            { 
                turnedRight = true;
                turnedLeft = false;
            }
    }

    public void endTurn()
    {        
        if (this.transform.parent.gameObject.GetComponent<Transform>().rotation.y == 0)
        {
            this.transform.parent.gameObject.GetComponent<Transform>().rotation = new Quaternion(0, 180, 0, 0);
        }
        else
        {
            this.transform.parent.gameObject.GetComponent<Transform>().rotation = new Quaternion(0, 0, 0, 0);
        }
        
        
    }
}
