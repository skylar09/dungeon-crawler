using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{

    public GameObject weapon;
    public bool swordSwung = false;
    public bool canAttack = true;
    public bool mouseIsLeft;
    public Quaternion startrotateright;


    // Start is called before the first frame update
    void Start()
    {
        //turns the weapon off
        weapon.SetActive(false);
        startrotateright = new Quaternion(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //gets the mouse position in pixels
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        //gets the real world position of the mouse by converting the pixels to acutal units
        //*use this to check swing left or right*
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
        
        //if left click
        if (Input.GetMouseButtonDown(0) && canAttack == true)
        {
            //turns the weapon on
            weapon.SetActive(true);

            swordSwung = true;
            canAttack = false;
        }

        float playerLocationX = PlayerInfo.playerLocation.x + .6f;
        float playerLocationY = PlayerInfo.playerLocation.y + .1f;

        
            if (swordSwung == true)
            {
                if (mouseIsLeft == true)
                {
                    //sets the weapon position to near the player
                    weapon.GetComponent<Transform>().position = PlayerInfo.playerLocation + new Vector3(-.65f, .1f, 0); 

                    //rotates the sword towards -90 degrees
                    weapon.transform.rotation = Quaternion.RotateTowards(weapon.transform.rotation, Quaternion.Euler(-1 * playerLocationX, playerLocationY, 90), PlayerInfo.swordSwingSpeed);
                
            
                    //checks the z component of the rotation of the weapon to see if it is 90
                    if (weapon.transform.localRotation.eulerAngles.z == 90)
                    {
                        //resets everything
                        restartVariables();

                    }
                }

                else
                {
                    //sets the weapon position to near the player
                    weapon.GetComponent<Transform>().position = PlayerInfo.playerLocation + new Vector3(.6f, .1f, 0); 
                    //rotates the sword towards -90 degrees
                    weapon.transform.rotation = Quaternion.RotateTowards(weapon.transform.rotation, Quaternion.Euler(playerLocationX, playerLocationY, -90), PlayerInfo.swordSwingSpeed);
                
            
                    //checks the z component of the rotation of the weapon to see if it is 270 (-90)
                    if (weapon.transform.localRotation.eulerAngles.z == 270)
                    {
                        //resets everything
                        restartVariables();

                    }
                }
            }

        
    }

    //resets rotation, swordswung, canAttack, and turns weapon off
    void restartVariables()
    {
        weapon.transform.rotation = startrotateright;
        weapon.SetActive(false);
        canAttack = true;
        swordSwung = false;
    }

    //this is used to wait a certain amount of time before doing something
    // IEnumerator Wait()
    // {
    //     yield return new WaitForSecondsRealtime(1/2);
        
    // }

    
}
