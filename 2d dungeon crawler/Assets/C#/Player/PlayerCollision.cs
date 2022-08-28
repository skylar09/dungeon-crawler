using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerCollision : MonoBehaviour
{
    public GameObject Camera;

    bool ignore = true;

    public static int currentRoom = 0;
    public static int closestRoom;

    void Start()
    {
        //makes it so all collisions on layers 6 (player) and 8 (weapon) are ignored
        Physics2D.IgnoreLayerCollision(6, 8, ignore);
    }

    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        //checks for the tag on the object it collides with        
        if (collisionInfo.collider.tag == "doorY")
        {
            doorY();
        }

        else if (collisionInfo.collider.tag == "doorX")
        {
           doorX();
        }
    }

    public void doorY()
    {
        whichRoomNext();

        //moves the camera
        Camera.transform.position = RoomLocation.roomCords[currentRoom];

        //moves the player to the entrance of the next room

        //moves the player to the bottom of the room
        if (PlayerInfo.playerLocation.y < RoomLocation.roomCords[currentRoom].y)
        {
            transform.position = new Vector2(RoomLocation.roomCords[currentRoom].x, RoomLocation.roomCords[currentRoom].y - 3.5f);
            Debug.Log("bla");
        }

        //moves the player to the top of the next room
        else
        {
            transform.position = new Vector2(RoomLocation.roomCords[currentRoom].x, RoomLocation.roomCords[currentRoom].y + 3.5f);
            Debug.Log("bla");
        }

        SpawnEnemy.enterRoom = true;
    }

    public void doorX()
    {
        whichRoomNext();
        
        //moves the player and the camera
        Camera.transform.position = RoomLocation.roomCords[currentRoom];

        //moves the player to the entrance of the next room

        //moves the player to the left of the room
        if (PlayerInfo.playerLocation.x < RoomLocation.roomCords[currentRoom].x)
        {
            transform.position = new Vector2(RoomLocation.roomCords[currentRoom].x - 9.5f, RoomLocation.roomCords[currentRoom].y);
            Debug.Log("bla");
        }

        //moves the player to the right of the room
        else
        {
            transform.position = new Vector2(RoomLocation.roomCords[currentRoom].x + 9.5f, RoomLocation.roomCords[currentRoom].y);
            Debug.Log("bla");
        }

        SpawnEnemy.enterRoom = true;
    }

    public void whichRoomNext()
    {
        double roomDistance = 999999999;

        //goes through all the rooms and finds the closest one
        for (int i = 0; i < RoomLocation.roomCords.Length; i ++)
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
        
        //the current room is set to the closest room
        currentRoom = closestRoom;
    }
}
