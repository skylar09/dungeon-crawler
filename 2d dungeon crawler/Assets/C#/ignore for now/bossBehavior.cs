using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class bossBehavior : MonoBehaviour
{
    public static Vector2 bossLocation;
    public Animator animator;

    private Transform target;

    public bool changeCollider = false;
    public int num = 1;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        bossLocation = new Vector2(this.GetComponent<Transform>().position.x, this.GetComponent<Transform>().position.y);

        if (bossLocation.x > PlayerInfo.playerLocation.x)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        else
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (PlayerCollision.currentRoom == 5 && Vector2.Distance(transform.position, target.position) - ((target.position.x + transform.position.x) / 2) < 6)
        {
            animator.SetBool("nearby", true);
            changeCollider = true;
        }

        else
        {
            animator.SetBool("nearby", false);
            changeCollider = false;
        }

        if (animator.GetBool("nearby") == true)
        {
            num = 1;
            // if (distance <= 2)
            // {
            //     // num = UnityEngine.Random.Range(1, 3);
            // }

            if (num == 1)
            {
                animator.SetInteger("whichAttack", 1);
            }
            
            else if (num == 2)
            {
                animator.SetInteger("whichAttack", 2);
            }
        }
        
        if (changeCollider == true)
        {
            Destroy(GetComponent<PolygonCollider2D>());
            gameObject.AddComponent<PolygonCollider2D>();
        }
    }
}
