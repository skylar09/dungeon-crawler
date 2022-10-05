using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doors : MonoBehaviour
{
    public List<GameObject> Doors = new List<GameObject>();
    public List<GameObject> Rooms = new List<GameObject>();

    public GameObject Camera;

    public static int cleared = 0;
    public int number;
    public bool opened = false;

    void Awake()
    {
        for (int i = 0; i < Rooms.Count; i++)
        {
            Rooms[i].GetComponent<doors>().number = i;
        }
    }

    void Update()
    {
        if (SpawnEnemy.enemyCount == 0 && number == cleared && opened == false)
        {
            openDoors();
            Camera.GetComponent<RoomLocation>().roomCleared[PlayerCollision.currentRoom] = true;
        }
    }

    void openDoors()
    {
        for (int i = 0; i < Doors.Count; i++)
        {
            Doors[i].SetActive(false);
        }
        opened = true;
    }
}
