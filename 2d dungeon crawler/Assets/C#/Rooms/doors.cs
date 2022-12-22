using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doors : MonoBehaviour{
    //the list of doors for this room
    public List<GameObject> Doors = new List<GameObject>();
    //the list of spawners for this room
    public List<GameObject> spawners = new List<GameObject>();

    void Update(){
        if (SpawnEnemy.enemyCount == 0){
            openDoors();
        }
    }

    //opens all the doors in this room
    private void openDoors(){
        foreach(GameObject door in Doors){
            //door.GetComponent<Animator>().SetTrigger("open");
        }
        //turns this door script off
        this.GetComponent<doors>().enabled = false;
    }

    //closes all the doors in this room
    public void closeDoors(){
        foreach(GameObject door in Doors){
            //door.GetComponent<Animator>().SetTrigger("close");
        }
        Debug.Log("a");
    }

    //destroys all of the enemy spawners in this room
    public void destroySpawners(){
        foreach(GameObject spawner in spawners)
            Destroy(spawner);
    }
}
