using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy;
    private GameObject CreatedEnemy;
    public static bool enterRoom = true;

    // Update is called once per frame
    void Update()
    {
        float LocationX = RoomLocation.roomCords[PlayerCollision.currentRoom].x;
        float LocationY = RoomLocation.roomCords[PlayerCollision.currentRoom].y;

        //should spawn enemy when you enter a new room
        if (enterRoom == true)
        {
            CreatedEnemy = Instantiate(Enemy, new Vector2(LocationX + 2, LocationY + 2), Quaternion.identity);
            enterRoom = false;
            Debug.Log("spawned");
        }

        if (enemyInfo.slimeHealth <= 0)
        {
            Destroy(CreatedEnemy);
            enemyInfo.slimeHealth = 4;
        }
    }
}
