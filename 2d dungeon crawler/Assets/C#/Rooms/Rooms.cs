using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooms : MonoBehaviour{
    public List<GameObject> rooms = new List<GameObject>();

    void Start(){
        for (int i = 0; i < rooms.Count - 1; i ++){
            rooms[i].GetComponent<doors>().nextRoom = rooms[i + 1];
        }
    }
}
