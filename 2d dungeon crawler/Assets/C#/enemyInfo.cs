using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyInfo : MonoBehaviour
{
    public static Vector3 enemyLocation;
    public GameObject enemy;

    public static int batHealth = 1;
    public static int batDamage = 1;
    public static int batDefense = 1;
    public static float batMoveSpeed = PlayerInfo.movementSpeed / 2;
    public static int batResistKnockback = 0;

    public static int slimeHealth = 4;
    public static int slimeDamage = 2;
    public static int slimeDefense = 2;
    public static float slimeMoveSpeed = 1;
    public static int slimeResistKnockback = 0;

    //makes array   note: to call a 2D array it goes vertical value then horizontal value --> [y, x]
    public int[,] enemyStats = {
        {1, 1, 1, 0},
        {4, 2, 2, 0}
    };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //makes enemy disappear if it's dead
        if (batHealth <= 0)
        {

        }

        enemyLocation = new Vector3(enemy.GetComponent<Transform>().position.x, enemy.GetComponent<Transform>().position.y, enemy.GetComponent<Transform>().position.z);
    }
}
