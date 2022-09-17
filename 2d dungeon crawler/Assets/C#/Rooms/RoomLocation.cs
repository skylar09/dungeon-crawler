using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomLocation : MonoBehaviour
{

    public List<Vector3> roomCords = new List<Vector3>();
    public static bool[] roomCleared = {false, false, false, false, false, false};
    public static bool[] newRoom = {false, true, true, true, false, true};
}