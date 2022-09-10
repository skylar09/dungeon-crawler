using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomLocation : MonoBehaviour
{

    public static Vector3[] roomCords = new Vector3[6];
    public static bool[] roomCleared = {false, false, false, false, false, false};
    public static bool[] newRoom = {false, true, true, true, false, true};
    
    // Start is called before the first frame update
    void Start()
    {
        //adds the room cords to this list also room 1 is at position 0 //we could differentiate betweeen Y and X rooms for faster computing
        roomCords[0] = new Vector3(0f, 0f, -10f);
        roomCords[1] = new Vector3(0f, 11f, -10f);
        roomCords[2] = new Vector3(23.3f, 11f, -10f);
        roomCords[3] = new Vector3(23.3f, 0f, -10f);
        roomCords[4] = new Vector3(0f, 22f, -10f);
        roomCords[5] = new Vector3(46.6f, 0f, -10f);

    }
}