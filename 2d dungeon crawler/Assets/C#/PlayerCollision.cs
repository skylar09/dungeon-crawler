using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerCollision : MonoBehaviour
{
    public GameObject Camera;
    public static int currentRoom = 1;
    public int closestRoom;

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

        if (collisionInfo.collider.tag == "doorY")
        {
            //teleport player and change camera to new room
            
            for (int i = 0; i < 3; i ++)
            {
                // for (int j = 0; j < 9; j++)
                // {
                    if (i + 1 != currentRoom)
                    {
                        if (Math.Abs(RoomLocation.roomCords[i].y - PlayerInfo.playerLocation.y) <= Math.Abs(RoomLocation.roomCords[closestRoom].y - PlayerInfo.playerLocation.y))
                        {



                            if (Math.Abs(RoomLocation.roomCords[i].x - PlayerInfo.playerLocation.x) < Math.Abs(RoomLocation.roomCords[closestRoom].x - PlayerInfo.playerLocation.x))
                            {
                                closestRoom = i;
                                Debug.Log(closestRoom);
                                Debug.Log("a");
                            }
                            
                            else
                            {
                                closestRoom = i + 1;
                                Debug.Log(closestRoom);
                                Debug.Log("b");
                            }
                        }
                    }
                    
                // }
            }
            Debug.Log(closestRoom);
            Debug.Log(RoomLocation.roomCords[closestRoom]);
            transform.position = RoomLocation.roomCords[closestRoom];
            Camera.transform.position = RoomLocation.roomCords[closestRoom];
            currentRoom = closestRoom;
            

        }
    }
}

