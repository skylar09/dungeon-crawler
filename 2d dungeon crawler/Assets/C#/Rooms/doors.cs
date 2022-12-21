using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doors : MonoBehaviour{
    //the list of doors for this room
    public List<GameObject> Doors = new List<GameObject>();
    //the list of spawners for this room
    public List<GameObject> spawners = new List<GameObject>();
    //a pointer to the next room 
    public GameObject nextRoom;

    void Update(){
        if (SpawnEnemy.enemyCount == 0){
            openDoors();
            NextRoom();
        }
    }

    //opens all the doors in this room
    private void openDoors(){
        foreach(GameObject door in Doors){
            //door.GetComponent<Animator>().SetTrigger("open");
        }
    }

    //closes all the doors in this room
    public void closeDoors(){
        foreach(GameObject door in Doors){
            //door.GetComponent<Animator>().SetTrigger("close");
        }
    }

    //enables the door script on the next room and disables it on this room
    private void NextRoom(){
        if (nextRoom != null)
            nextRoom.GetComponent<doors>().enabled = true;
        this.GetComponent<doors>().enabled = false;
    }

    //destroys all of the enemy spawners in this room
    public void destroySpawners(){
        foreach(GameObject spawner in spawners)
            Destroy(spawner);
    }
}
