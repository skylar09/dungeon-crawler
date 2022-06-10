using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerCollision : MonoBehaviour
{
    public GameObject Camera;
    int currentRoom = 0;
    int closestRoom;

    // Update is called once per frame
    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        //checks for the tag on the object it collides with
        if (collisionInfo.collider.tag == "enemy")
        {
            //changes the player health
            PlayerInfo.playerHealth = PlayerInfo.playerHealth - (Math.Abs(PlayerInfo.playerDefense - 4));

            Debug.Log(PlayerInfo.playerHealth);
        }

        
        if (collisionInfo.collider.tag == "door")
        {
            double roomDistance = 999999999;

            //teleport player and change camera to new room

            for (int i = 0; i < 4; i ++)
            {
                if (i != currentRoom)
                {
                    //gets distance between player and the room at i in the room array
                    double localDistance = Math.Sqrt(Math.Pow((RoomLocation.roomCords[i].y - PlayerInfo.playerLocation.y), 2) + Math.Pow((RoomLocation.roomCords[i].x - PlayerInfo.playerLocation.x), 2));
                    
                    //makes roomDistance the current distance if it is shorter than the previous one
                    if (localDistance < roomDistance)
                    {
                        roomDistance = localDistance;
                        closestRoom = i;
                    }
                }
            }
            
            currentRoom = closestRoom;
            //moves the player and the camera
            transform.position = RoomLocation.roomCords[closestRoom];
            Camera.transform.position = RoomLocation.roomCords[closestRoom];
        }
    }
}

