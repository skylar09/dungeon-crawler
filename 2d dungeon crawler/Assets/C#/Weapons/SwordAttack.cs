using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class SwordAttack : MonoBehaviour
{

    public bool swordSwung = false;
    public bool canAttack = true;
    public bool mouseIsLeft;
    
    public GameObject refrence;
    public Weapons WeaponsScript;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        WeaponsScript = refrence.GetComponent<Weapons>();
        
        //turns the weapon off
        WeaponsScript.yourWeapon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //gets the mouse position in pixels
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        //gets the real world position of the mouse by converting the pixels to acutal units
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);  

        if (swordSwung != true)
        {
            //checks if the mouse is to the right or left of the player
            if (PlayerInfo.playerLocation.x >= worldPosition.x)
            {
                mouseIsLeft = true;
            }

            else
            {
                mouseIsLeft = false;
            }
        }
        
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            //if left click
            if (Input.GetMouseButtonDown(0) && canAttack == true)
            {
                activateWeapon();
            }
        }
        
        if (swordSwung == true)
        {
            if (mouseIsLeft == true)
            {
                attackLeft();
            }

            else
            {
                attackRight();
            }
        }
    }

    public void activateWeapon()
    {
        //turns the weapon on
        WeaponsScript.yourWeapon.SetActive(true);

        swordSwung = true;
        canAttack = false;
    }

    public void attackLeft()
    {
        //sets the weapon position to near the player
        WeaponsScript.yourWeapon.GetComponent<Transform>().position = PlayerInfo.playerLocation + new Vector3(-.65f, .1f, 0); 

        animator.SetBool("attackRight", false);
    }

    public void attackRight()
    {
        //sets the weapon position to near the player
        WeaponsScript.yourWeapon.GetComponent<Transform>().position = PlayerInfo.playerLocation + new Vector3(.65f, .1f, 0); 

        animator.SetBool("attackRight", true);
    }

    //resets rotation, swordswung, canAttack, and turns weapon off
    public void restartVariables()
    {
        WeaponsScript.yourWeapon.SetActive(false);
        canAttack = true;
        swordSwung = false;
    }

    //this is used to wait a certain amount of time before doing something
    // IEnumerator Wait()
    // {
    //     yield return new WaitForSecondsRealtime(1/2);
        
    // }

    
}
