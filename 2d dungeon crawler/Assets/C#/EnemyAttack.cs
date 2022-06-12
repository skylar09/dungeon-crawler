using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyAttack : MonoBehaviour
{

    public Animator bat_attack;

    // Start is called before the first frame update
    void Start()
    {
        bat_attack.SetBool("Attack", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Math.Sqrt(Math.Pow((Math.Abs(enemyInfo.enemyLocation.y) - Math.Abs(PlayerInfo.playerLocation.y)), 2) + Math.Pow((Math.Abs(enemyInfo.enemyLocation.x) - Math.Abs(PlayerInfo.playerLocation.x)), 2)) <= 1.7)
        
        {
            bat_attack.SetBool("Attack", true);
        }

        else
        {
            bat_attack.SetBool("Attack", false);
            // Debug.Log(Math.Sqrt(Math.Pow((enemyInfo.enemyLocation.y - PlayerInfo.playerLocation.y), 2) + Math.Pow((enemyInfo.enemyLocation.x - PlayerInfo.playerLocation.x), 2)));
        }
        
    }
}
