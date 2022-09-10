using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public List<GameObject> Enemies = new List<GameObject>();

    public static bool enterRoom = false;
    public static int enemyCount = 0;

    void Start()
    {
        //spawns 1 bat in the first room
        if (PlayerCollision.currentRoom == 0)
        {
            Instantiate(Enemies[0], new Vector2(4, 3), Quaternion.identity);
            enemyCount++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //should spawn enemy when you enter a new room
        if (enterRoom == true && RoomLocation.newRoom[PlayerCollision.currentRoom] == true)
        {
            spawn();
        }        
    }

    //spawns enemies in certain spots around the room
    public void spawn()
    {
        RoomLocation.newRoom[PlayerCollision.currentRoom] = false;

            float LocationX = RoomLocation.roomCords[PlayerCollision.currentRoom].x;
            float LocationY = RoomLocation.roomCords[PlayerCollision.currentRoom].y;

            int numOfEnemies = Random.Range(2, 5);

            for (int i = 0; i < numOfEnemies; i++)
            {
                //for int min inclusive max exclusive 
                //for float both inclusive
                int enemyNum = Random.Range(0, Enemies.Count);
                
                //gives either 1 or -1
                int leftOrRight = Random.Range(0, 2) * 2 - 1;
                int upOrDown = Random.Range(0, 2) * 2 - 1;

                //creates a version of an enemy prefab
                Instantiate(Enemies[enemyNum], new Vector2(LocationX + (Random.Range(3f, 7f) * leftOrRight), LocationY + (Random.Range(1.5f, 3f)) * upOrDown), Quaternion.identity);

                enemyCount++;
            }

        enterRoom = false;
        doors.cleared ++;
    }
}
