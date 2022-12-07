using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doors : MonoBehaviour{
    //the list of doors for this room
    public List<GameObject> Doors = new List<GameObject>();
    public GameObject nextRoom;

    void Update(){
        if (SpawnEnemy.enemyCount == 0){
            openDoors();
            NextRoom();
        }
    }

    //opens all the doors
    private void openDoors(){
        foreach(GameObject door in Doors){
            //door.GetComponent<Animator>().SetTrigger("open");
        }
    }

    public void closeDoors(){
        foreach(GameObject door in Doors){
            //door.GetComponent<Animator>().SetTrigger("close");
        }
    }

    private void NextRoom(){
        if (nextRoom != null)
            nextRoom.GetComponent<doors>().enabled = true;
        this.GetComponent<doors>().enabled = false;
    }
}
