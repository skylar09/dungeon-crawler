using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class weaponRotate : MonoBehaviour
{
    //mouse position
    public static Vector3 mouse_pos;
    //player position
    public static Vector3 object_pos;
    //angle to rotate weapon to, cos of that angle(in degrees), sin of that angle(in degrees)
    public static float angle, cos, sin;
    public float radius;
 
    public void Update(){
        //stops weapon from rotation when inventory is open (or other thing is open in future)
        if (!EventSystem.current.IsPointerOverGameObject()){
                //if weapon is not currently attacking
                if (Weapons.swordSwung != true){
                    rotate();
            }
        }
        
        setPosition();        
    } 

    //rotates weapon so it faces the mouse position (the tip of the weapon or where projectile comes from on gun)
    public void rotate(){
        //gets the mouse position and player position in pixels
        mouse_pos = Input.mousePosition;
        object_pos = Camera.main.WorldToScreenPoint(PlayerInfo.playerLocation);
        //mouse position (x,y) now equal to difference between mouse position and player position
        mouse_pos.x = mouse_pos.x - object_pos.x;
        mouse_pos.y = mouse_pos.y - object_pos.y;
        //using arctan to get the angle from new mouse posiiton
        angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;

        //canges weapon rotation and sorting order based on if mouse is left or right of player
        if (mouse_pos.x > 0){
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 90 - angle));
            this.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sortingOrder = 5; 
        }
        else{
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
            this.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sortingOrder = 3; 
        }
    }

    //sets weapon position on the perimiter of a circle centered on the player based on radius given for weapon
    public void setPosition(){
        cos = Mathf.Cos(angle * Mathf.PI / 180);
        sin = Mathf.Sin(angle * Mathf.PI / 180);

        float posX = PlayerInfo.playerLocation.x + (cos * radius);
        float posY = PlayerInfo.playerLocation.y + (sin * radius);
        transform.position = new Vector3(posX, posY, 0);
        //transform.position = PlayerInfo.playerLocation;
    }
}
