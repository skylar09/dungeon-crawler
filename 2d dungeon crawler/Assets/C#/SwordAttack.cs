using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{

    public GameObject weapon;
    bool swordSwung = false;
    bool rotateToPosition = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           weapon.GetComponent<Transform>().position = PlayerInfo.playerLocation + new Vector3(.6f, .1f, 0); 

        //if left click
        if (Input.GetMouseButtonDown(0))
        {
            // swingSword();
            swordSwung = true;
        }

        float playerLocationX = PlayerInfo.playerLocation.x + .6f;
        float playerLocationY = PlayerInfo.playerLocation.y + .1f;

        //rotates sword as if it were swung
        if (swordSwung == true)
        {
            this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, Quaternion.Euler(playerLocationX, playerLocationY, -90), PlayerInfo.swordSwingSpeed);
            StartCoroutine(Wait());
        }

        //rotates sword back to orignial position
        if (rotateToPosition == true)
        {
            this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, Quaternion.Euler(playerLocationX, playerLocationY, -45), PlayerInfo.swordSwingSpeed);
            rotateToPosition = false;
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(1);
        rotateToPosition = true;
        swordSwung = false;
    }

    
}
