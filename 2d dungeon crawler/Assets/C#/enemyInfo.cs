using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyInfo : MonoBehaviour
{

    public static int enemyHealth = 1;
    public static int enemyDamage = 4;
    public static int enemyDefense = 2;
    public static float enemyMoveSpeed = 1;
    public static Vector3 enemyLocation;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyMoveSpeed = (PlayerInfo.movementSpeed / 2);

        //makes enemy disappear if it's dead
        if (enemyHealth <= 0)
        {

        }

        enemyLocation = new Vector3(enemy.GetComponent<Transform>().position.x, enemy.GetComponent<Transform>().position.y, enemy.GetComponent<Transform>().position.z);
    }
}
