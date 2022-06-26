using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject slime;
    public GameObject bat;
    public static bool enterRoom = false;

    void Start()
    {
        if (PlayerCollision.currentRoom == 0)
        {
            Instantiate(bat, new Vector2(3, 2), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float LocationX = RoomLocation.roomCords[PlayerCollision.currentRoom].x;
        float LocationY = RoomLocation.roomCords[PlayerCollision.currentRoom].y;

        //should spawn enemy when you enter a new room
        if (enterRoom == true)
        {
            for (int i = 0; i < 3; i++)
            {
                int num = Random.Range(0, 2);
                Debug.Log(num);

                if (num == 0)
                {
                    //creates a version of an enemy prefab
                    Instantiate(bat, new Vector2(LocationX + Random.Range(2f, 4f), LocationY + Random.Range(1.5f, 3f)), Quaternion.identity);
                }

                else if (num == 1)
                {
                    //creates a version of an enemy prefab
                    Instantiate(slime, new Vector2(LocationX + Random.Range(2f, 4f), LocationY + Random.Range(1.5f, 3f)), Quaternion.identity);
                }
            }
            
            enterRoom = false;
            Debug.Log("spawned");
        }        
    }
}
