using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doors : MonoBehaviour
{
    //the list of doors for this room
    public List<GameObject> Doors = new List<GameObject>();
    //camera gameObject
    public GameObject Camera;
    //which rooms are cleared
    public static int cleared = 0;
    //used to make sure if doors should be open or closed (if new room or not)
    public int number;
    //tracks if doors are closed or open
    public bool opened = false;

    void Update()
    {
        //if all enemies are dead, this room is cleared, and doors arn't already open then open the doors
        if (SpawnEnemy.enemyCount == 0 && number == cleared && opened == false)
        {
            openDoors();
            Camera.GetComponent<RoomLocation>().roomCleared[PlayerCollision.currentRoom] = true;
        }
    }

    //opens all the doors
    void openDoors()
    {
        for (int i = 0; i < Doors.Count; i++)
        {
            Doors[i].SetActive(false);
        }
        opened = true;
    }
}
