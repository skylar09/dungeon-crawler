using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollision : MonoBehaviour{
    public void OnCollisionEnter2D(Collision2D collision){
        if (collision.collider.tag == "Player"){
            //closes the doors in this room
            transform.parent.GetComponent<doors>().closeDoors();
            //spawns enemies in this room
            transform.parent.parent.GetComponent<Rooms>().spawnManager.GetComponent<SpawnEnemy>().spawn(transform.parent.transform.position);
            //turns the doors script of the room on
            transform.parent.gameObject.GetComponent<doors>().enabled = true;
            //destroys all the enemy spawners in this room
            transform.parent.GetComponent<doors>().destroySpawners();
        }
    }
}
