using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy;
    private GameObject createdEnemy;

    // Start is called before the first frame update
    void Start()
    {
        createdEnemy = Instantiate(Enemy, new Vector2(2, 2), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyInfo.slimeHealth <= 0)
        {
            Destroy(createdEnemy);
        }
    }
}
