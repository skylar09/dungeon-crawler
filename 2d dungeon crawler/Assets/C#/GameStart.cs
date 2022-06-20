// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class GameStart : MonoBehaviour
// {

//     public GameObject BatEnemy;


//     // Start is called before the first frame update
//     void Start()
//     {
//         //creates a version of an enemy prefab
//         Instantiate(BatEnemy, new Vector2(0, 2), Quaternion.identity);
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         //checks to see if the enemy health is 0 or less
//         if (enemyInfo.batHealth <= 0)
//         {
//             //destroys (kills) the enemy
//             Destroy(gameObject);

//             //resets bat health so when a new bat is created it has health of 1
//             //**should find a way to make it so this doesnt need to happen bc it might kill all bats alive at once**
//             enemyInfo.batHealth = 1;
//         }
//     }
// }
