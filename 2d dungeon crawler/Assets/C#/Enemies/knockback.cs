using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knockback : MonoBehaviour
{
    float thrust = 1;

    Rigidbody2D enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        thrust = Weapons.currentKnockback;
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("weapon") && thrust > 0)
        {
            enemy = this.GetComponent<Rigidbody2D>();

            this.GetComponent<enemyMovement>().canMove = false;

            Vector2 difference = transform.position - collider.transform.position;
            difference = difference.normalized * thrust;
            this.GetComponent<Rigidbody2D>().AddForce(difference, ForceMode2D.Impulse);

            StartCoroutine(knockbackOccur());
        }
    }

    IEnumerator knockbackOccur()
    {
        Debug.Log("herea"); 
        yield return new WaitForSecondsRealtime(1);
        Debug.Log("here");  
        enemy.velocity = new Vector2(0,0);
        this.GetComponent<enemyMovement>().canMove = true;
    }
}
