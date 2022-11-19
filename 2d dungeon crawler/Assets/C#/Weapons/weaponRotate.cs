using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class weaponRotate : MonoBehaviour
{
    public static Vector3 mouse_pos;
    public static Vector3 object_pos;
    float angle;
    public float radius;
 
    public void Update(){
        if (!EventSystem.current.IsPointerOverGameObject()){
                if (Weapons.swordSwung != true){
                    rotate();
            }
        }
        
        setPosition();        
    } 

    public void rotate(){
        mouse_pos = Input.mousePosition;
        object_pos = Camera.main.WorldToScreenPoint(PlayerInfo.playerLocation);
        //Debug.Log(object_pos);
        mouse_pos.x = mouse_pos.x - object_pos.x;
        mouse_pos.y = mouse_pos.y - object_pos.y;
        
        angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));

        if (mouse_pos.x > 0){
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 90 - angle));
            this.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sortingOrder = 5; 
        }
        else{
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
            this.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sortingOrder = 3; 
        }
    }

    public void setPosition(){
        float posX = PlayerInfo.playerLocation.x + (Mathf.Cos(angle * Mathf.PI / 180) * radius);
        float posY = PlayerInfo.playerLocation.y + (Mathf.Sin(angle * Mathf.PI / 180) * radius);
        transform.position = new Vector3(posX, posY, 0);
        //transform.position = PlayerInfo.playerLocation;
    }
}
