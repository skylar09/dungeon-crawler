using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{

    public GameObject weapon;
    public bool swordSwung = false;
    public bool canAttack = true;
    public Quaternion startingRotation;

    // Start is called before the first frame update
    void Start()
    {
        //turns the weapon off
        weapon.SetActive(false);
        startingRotation = weapon.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        weapon.GetComponent<Transform>().position = PlayerInfo.playerLocation + new Vector3(.6f, .1f, 0); 

        float playerLocationX = PlayerInfo.playerLocation.x + .6f;
        float playerLocationY = PlayerInfo.playerLocation.y + .1f;

        //if left click
        if (Input.GetMouseButtonDown(0) && canAttack == true)
        {
            //turns the weapon on
            weapon.SetActive(true);

            swordSwung = true;
            canAttack = false;
        }

        if (swordSwung == true)
        {
            //rotates the sword
            weapon.transform.rotation = Quaternion.RotateTowards(weapon.transform.rotation, Quaternion.Euler(playerLocationX, playerLocationY, -90), PlayerInfo.swordSwingSpeed);
        }
    
        
        if (weapon.transform.localRotation.eulerAngles.z == 270)
        {
            // Debug.Log("a");
            // StartCoroutine(Wait());
            weapon.transform.rotation = startingRotation;
            weapon.SetActive(false);
            canAttack = true;
            swordSwung = false;

        }
    }

    //this is used to wait a certain amount of time before doing something
    // IEnumerator Wait()
    // {
    //     yield return new WaitForSecondsRealtime(1/2);
        
    // }

    
}
