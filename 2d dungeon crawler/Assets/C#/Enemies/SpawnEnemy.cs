using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    //list of all enemy prefabs
    public List<GameObject> Enemies = new List<GameObject>();

    //tracks how many alive enemies in a room
    public static int enemyCount = 0;

    void Start()
    {
        //spawns 1 bat in the first room
            Instantiate(Enemies[0], new Vector2(4, 3), Quaternion.identity);
            enemyCount++;
    }

    public void OnCollisionEnter2D(Collision2D collision){
        if (collision.collider.tag == "Player"){
            makeDoor();
            spawn();
            Destroy(this.gameObject);
        }
    }

    public void makeDoor(){
        Debug.Log(transform.rotation.z);
        if (this.transform.rotation.z == 0)
        Instantiate(this.transform.GetChild(0).gameObject, this.transform.position - new Vector3(0, 1, 0), this.transform.rotation);
        else if (this.transform.rotation.z == 90){
        Instantiate(this.transform.GetChild(0).gameObject, this.transform.position - new Vector3(1, 0, 0), this.transform.rotation);
        Debug.Log("a");
        }
        else if (this.transform.rotation.z == 180)
        Instantiate(this.transform.GetChild(0).gameObject, this.transform.position - new Vector3(0, -1, 0), this.transform.rotation);
        else if (this.transform.rotation.z == 270)
        Instantiate(this.transform.GetChild(0).gameObject, this.transform.position - new Vector3(-1, 0, 0), this.transform.rotation);
    }

    //spawns enemies in certain random spots around the room
    public void spawn()
    {
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
            Instantiate(Enemies[enemyNum], new Vector2((Random.Range(3f, 7f) * leftOrRight), 5 + (Random.Range(1.5f, 3f)) * upOrDown), Quaternion.identity);

            enemyCount++;
        }
    }
}
