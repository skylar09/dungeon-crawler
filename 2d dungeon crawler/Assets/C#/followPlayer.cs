using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    Vector3 offset = new Vector3(0, 0, -10);
    [Range(1, 10)]
    public float smoothFactor;

    // Update is called once per frame
    void FixedUpdate()
    {
        follow();
    }

    public void follow(){
        Vector3 target = PlayerInfo.playerLocation + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, target, smoothFactor * Time.fixedDeltaTime); 
        transform.position = smoothedPosition;
    }
}
