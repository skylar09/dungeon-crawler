using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomLocation : MonoBehaviour
{

    public static Vector3[] roomCords = new Vector3[4];
    
    // Start is called before the first frame update
    void Start()
    {
        //adds the room cords to this list also room 1 is at position 0
        roomCords[0] = new Vector3(0f, 0f, -10f);
        roomCords[1] = new Vector3(0f, 11f, -10f);
        roomCords[2] = new Vector3(23.3f, 11f, -10f);
        roomCords[3] = new Vector3(23.3f, 0f, -10f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}