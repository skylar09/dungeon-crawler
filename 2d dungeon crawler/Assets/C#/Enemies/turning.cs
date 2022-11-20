using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turning : MonoBehaviour
{
    public Animator animator;
    bool turnedRight = false;
    bool turnedLeft = true;
    
    // Update is called once per frame
    void Update()
    {
        //if the player is to one side of the enemy and it is not already turned that way then it turnes
        if (PlayerInfo.playerLocation.x >  this.transform.parent.gameObject.transform.position.x && turnedRight != true)
        {
            turn();
        }
        else if (PlayerInfo.playerLocation.x <  this.transform.parent.gameObject.transform.position.x && turnedLeft != true)
        {
            turn();
        }
    }

    //does turn animation then updates which way enemy is turned
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

    //when turn animation ends updates rotation of enemy so they facing correct direction
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
