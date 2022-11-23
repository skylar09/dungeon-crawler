using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    //list of all enemy prefabs
    public List<GameObject> Enemies = new List<GameObject>();

    public GameObject Camera;

    public static bool enterRoom = false;
    //tracks how many alive enemies in a room
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
        if (enterRoom == true && Camera.GetComponent<RoomLocation>().roomCleared[PlayerCollision.currentRoom] != true)
        {
            spawn();
        }        
    }

    //spawns enemies in certain random spots around the room
    public void spawn()
    {
        Camera.GetComponent<RoomLocation>().roomCleared[PlayerCollision.currentRoom] = false;

        float LocationX = Camera.GetComponent<RoomLocation>().Rooms[PlayerCollision.currentRoom].transform.position.x;
        float LocationY = Camera.GetComponent<RoomLocation>().Rooms[PlayerCollision.currentRoom].transform.position.y;

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
        doors.cleared ++;
        enterRoom = false;
    }
}
