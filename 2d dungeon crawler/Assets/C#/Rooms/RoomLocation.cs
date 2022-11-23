using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomLocation : MonoBehaviour
{
    //the rooms themselves
    public List<GameObject> Rooms = new List<GameObject>();
    //positions of all rooms
   // public static List<Vector3> roomCords = new List<Vector3>();
    //if player has defeated all enemies in room
    public List<bool> roomCleared = new List<bool>();

    //when level is loaded gets the positions for all the rooms and adds them to roomCords
    void Awake()
    {
        for (int i = 0; i < Rooms.Count; i++)
        {
            Rooms[i].GetComponent<doors>().number = i;
        }
    }
}