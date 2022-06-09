using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyInfo : MonoBehaviour
{

    public static int enemyHealth = 1;
    public static int enemyDamage = 4;
    public static int enemyDefense = 2;
    public static float enemyMoveSpeed = (PlayerInfo.movementSpeed / 3);

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
    }
}
