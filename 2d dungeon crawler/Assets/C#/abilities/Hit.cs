using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    //when Hit script is added to an enemy it waits 5 seconds then removes itself from the enemy
    void Awake(){
        StartCoroutine(killWait());
    }

    IEnumerator killWait()
    {
        yield return new WaitForSecondsRealtime(5f);
        Destroy(this);     
    }
}
