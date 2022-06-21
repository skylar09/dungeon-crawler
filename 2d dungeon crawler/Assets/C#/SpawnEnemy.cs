using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject slime;
    public GameObject bat;
    public static bool enterRoom = true;

    // Update is called once per frame
    void Update()
    {
        float LocationX = RoomLocation.roomCords[PlayerCollision.currentRoom].x;
        float LocationY = RoomLocation.roomCords[PlayerCollision.currentRoom].y;

        //should spawn enemy when you enter a new room
        if (enterRoom == true)
        {
            //creates a version of an enemy prefab
            //**need to make it so more than one type of enemy spawns in certain rooms**
            Instantiate(slime, new Vector2(LocationX + 2, LocationY + 2), Quaternion.identity);
            Instantiate(slime, new Vector2(LocationX + 2, LocationY + 2), Quaternion.identity);
            Instantiate(bat, new Vector2(LocationX + 3, LocationY + 2), Quaternion.identity);
            Instantiate(bat, new Vector2(LocationX + 3, LocationY + 2), Quaternion.identity);
            enterRoom = false;
            Debug.Log("spawned");
        }        
    }
}
