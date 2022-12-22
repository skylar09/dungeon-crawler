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

}
