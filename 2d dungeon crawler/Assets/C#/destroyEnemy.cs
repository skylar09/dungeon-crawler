using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyInfo.batHealth <= 0)
        {
            //destroys (kills) the enemy
            Destroy(gameObject);

            //resets bat health so when a new bat is created it has health of 1
            //**should find a way to make it so this doesnt need to happen bc it resets all current bat healths to 1**
            enemyInfo.batHealth = 1;
        }
        
         if (enemyInfo.slimeHealth <= 0)
        {
            //destroys (kills) the enemy
            Destroy(gameObject);

             //resets slime health so when a new slime is created it has health of 4
            //**should find a way to make it so this doesnt need to happen bc it resets all current slime healths to 4**
            enemyInfo.slimeHealth = 4;
        }
    }
}
