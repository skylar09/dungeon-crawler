using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    void Awake(){
        StartCoroutine(killWait());
    }

    IEnumerator killWait()
    {
        yield return new WaitForSecondsRealtime(5f);
        Destroy(this);     
    }
}
