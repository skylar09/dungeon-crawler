using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerCollision : MonoBehaviour
{
    //camera gameObject
    public GameObject Camera;
    //what is the curent room number
    public static int currentRoom = 0;
    //what is the closest room number
    public static int closestRoom;

    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        //if player hit a door with correct tag then call method     
        if (collisionInfo.collider.tag == "doorY")
        {
            doorY();
        }

        else if (collisionInfo.collider.tag == "doorX")
        {
           doorX();
        }
    }

    //teleports the player to the next room above or below the current one
    public void doorY()
    {
        whichRoomNext();

        //moves the camera
        Camera.transform.position = Camera.GetComponent<RoomLocation>().Rooms[currentRoom].transform.position + new Vector3(0,0,-10);

        //moves the player to the entrance of the next room

        //moves the player to the bottom of the room
        if (PlayerInfo.playerLocation.y < Camera.transform.position.y)
        {
            transform.position = new Vector2(Camera.transform.position.x, Camera.transform.position.y - 3.5f);
        }

        //moves the player to the top of the next room
        else
        {
            transform.position = new Vector2(Camera.transform.position.x, Camera.transform.position.y + 3.5f);
        }

        SpawnEnemy.enterRoom = true;
    }

    //teleports the player to the next room to the right or left of the current one
    public void doorX()
    {
        whichRoomNext();
        
        //moves the player and the camera
        Camera.transform.position = Camera.GetComponent<RoomLocation>().Rooms[currentRoom].transform.position + new Vector3(0,0,-10);

        //moves the player to the entrance of the next room

        //moves the player to the left of the room
        if (PlayerInfo.playerLocation.x < Camera.transform.position.x)
        {
            transform.position = new Vector2(Camera.transform.position.x - 8f, Camera.transform.position.y);
        }

        //moves the player to the right of the room
        else
        {
            transform.position = new Vector2(Camera.transform.position.x + 8f, Camera.transform.position.y);
        }

        SpawnEnemy.enterRoom = true;
    }

    //figrues out which room is closest to the current one
    public void whichRoomNext()
    {
        double roomDistance = 999999999;
        
        //goes through all the rooms and finds the closest one
        for (int i = 0; i < Camera.GetComponent<RoomLocation>().Rooms.Count; i ++)
        {
            if (i != currentRoom)
            {
                float x = Camera.GetComponent<RoomLocation>().Rooms[i].transform.position.x;
                float y = Camera.GetComponent<RoomLocation>().Rooms[i].transform.position.y;

                //gets distance between player and the room at i in the room array
                double localDistance = Math.Sqrt(Math.Pow((y - PlayerInfo.playerLocation.y), 2) + Math.Pow((x - PlayerInfo.playerLocation.x), 2));
                
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

