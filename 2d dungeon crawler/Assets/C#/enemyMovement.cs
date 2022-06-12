using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        //sets target as the GameObject with the tag "Player"
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //makes the enemy move towards the player
        transform.position = Vector2.MoveTowards(transform.position, target.position, enemyInfo.enemyMoveSpeed * Time.deltaTime);
    }
}
