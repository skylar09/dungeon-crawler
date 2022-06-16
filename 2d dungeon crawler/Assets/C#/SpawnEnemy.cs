using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy;
    private GameObject createdEnemy;
    public static bool enterRoom = true;

    // Update is called once per frame
    void Update()
    {
        //should spawn enemy when you enter a new room
        if (enterRoom == true)
        {
            createdEnemy = Instantiate(Enemy, new Vector2(2, 2), Quaternion.identity);
            enterRoom = false;
        }

        if (enemyInfo.slimeHealth <= 0)
        {
            Destroy(createdEnemy);
        }
    }
}
