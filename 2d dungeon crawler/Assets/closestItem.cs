using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closestItem : MonoBehaviour
{
    public static GameObject closest;

    void Update()
    {
        if (this != closest){
            float dist = closest.GetComponent<pickUpItem>().getDist();
            if (dist > this.getDist()){}
                //closest = this.GameObject;
        }
        //if (Input.GetKeyDown("f") && buttonPressed == false){}
    }

    public float getDist(){
        return Vector2.Distance(this.transform.position, PlayerInfo.playerLocation);
    }
}
