using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomLocation : MonoBehaviour
{
    public List<GameObject> Rooms = new List<GameObject>();
    public static List<Vector3> roomCords = new List<Vector3>();
    public List<bool> roomCleared = new List<bool>();
    public List<bool> newRoom = new List<bool>();

    void Awake()
    {
        roomCords.Clear();
        for (int i = 0; i < Rooms.Count; i++)
        {
            roomCords.Add(Rooms[i].transform.position);
        }
    }
}