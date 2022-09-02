using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knockback : MonoBehaviour
{
    public float thrust = 5;

    Rigidbody2D enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("slimeEnemy"))
        {
            enemy = collider.rigidbody;
            if (enemy != null)
            {
                collider.gameObject.GetComponent<enemyMovement>().canMove = false;

                Vector2 difference = enemy.transform.position - transform.position;
                difference = difference.normalized * thrust;
                enemy.AddForce(difference, ForceMode2D.Impulse);

                StartCoroutine(knockbackOccur());
            }
        }
    }

    IEnumerator knockbackOccur()
    {
        Debug.Log("herea"); 
        yield return new WaitForSecondsRealtime(5);
        Debug.Log("here");  
        enemy.velocity = new Vector2(0,0);
        enemy.gameObject.GetComponent<enemyMovement>().canMove = true;
    }
}
