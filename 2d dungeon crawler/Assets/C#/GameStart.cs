using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{

    public GameObject BatEnemy;
    private GameObject createdEnemy;


    // Start is called before the first frame update
    void Start()
    {
        createdEnemy = Instantiate(BatEnemy, new Vector2(0, 2), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyInfo.batHealth <= 0)
        {
            Destroy(createdEnemy);
        }
    }
}
