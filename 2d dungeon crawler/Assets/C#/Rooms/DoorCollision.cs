using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollision : MonoBehaviour{
    public void OnCollisionEnter2D(Collision2D collision){
        if (collision.collider.tag == "Player"){
            transform.parent.GetComponent<doors>().closeDoors();
            transform.parent.parent.GetComponent<Rooms>().spawnManager.GetComponent<SpawnEnemy>().spawn(transform.parent.transform.position);
            Destroy(this.gameObject);
        }
    }
}
