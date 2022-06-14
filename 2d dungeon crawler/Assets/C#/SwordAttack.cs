using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{

    public GameObject weapon;
    bool swordSwung = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (swordSwung == false)
        {
           weapon.GetComponent<Transform>().position = PlayerInfo.playerLocation + new Vector3(.6f, .1f, 0); 
        }

        if (Input.GetMouseButtonDown(0))
        {
            swingSword();
        }
    }

    void swingSword()
    {
        weapon.GetComponent<Transform>().position = PlayerInfo.playerLocation + new Vector3(2, 2, 0);
        weapon.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        weapon.GetComponent<Rigidbody2D>().angularVelocity = 0;
        swordSwung = true;
        StartCoroutine(PauseWait());
    }

    IEnumerator PauseWait()
    {
        yield return new WaitForSecondsRealtime(1);
        swordSwung = false;
    }
}
