using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class bossBehavior : MonoBehaviour
{
    public Vector2 bossLocation;
    public Animator animator;

    public bool changeCollider = false;
    public int num = 1;
    public int fireballs = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bossLocation = new Vector2(this.GetComponent<Transform>().position.x, this.GetComponent<Transform>().position.y);

        double distance = Math.Sqrt(Math.Pow((bossLocation.y - PlayerInfo.playerLocation.y), 6) + Math.Pow((bossLocation.x - PlayerInfo.playerLocation.x), 6));

        if (distance <= 2)
        {
            // num = UnityEngine.Random.Range(1, 3);
        }

        if (num == 1)
        {
            animator.SetBool("fireball", true);
        }
        
        else if (num ==2)
        {
            animator.SetBool("headbutt", true);
        }


        if (PlayerCollision.currentRoom == 5)
        {
            animator.SetBool("nearby", true);
            changeCollider = true;
        }

        else
        {
            animator.SetBool("nearby", false);
            changeCollider = false;
        }
        
        if (changeCollider == true)
        {
            Destroy(GetComponent<PolygonCollider2D>());
            gameObject.AddComponent<PolygonCollider2D>();
        }
    }
}
