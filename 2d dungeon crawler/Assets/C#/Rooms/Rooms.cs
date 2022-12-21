using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooms : MonoBehaviour{
    //list of all the rooms
    public List<GameObject> rooms = new List<GameObject>();
    //object that has list of enemies that can spawn on this level
    public GameObject spawnManager;

    void Awake(){
        //sets spawnManager to the GameObject named spawnManager in the scene
        spawnManager = GameObject.Find("spawnManager");
    }

    void Start(){
        //assigns nextRoom variable to the next room in the list
        //the last room's variable is not assigned and is null
        for (int i = 0; i < rooms.Count - 1; i ++){
            rooms[i].GetComponent<doors>().nextRoom = rooms[i + 1];
        }
    }
}
