using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossAttack : MonoBehaviour
{
    Animator animator;

    public GameObject Fireball;

    public Rigidbody2D rb;

    public int fireballs = 0;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //shoots fireballs
    void fireball()
    {
        //get it so that it moves towards the players previous location at constant speed and is facing the player
        var fireballCopy = Instantiate(Fireball, bossBehavior.bossLocation , Quaternion.identity);
      
        //this makes the fireballs face where the player was when they were spawned
        // Get Angle in Radians
        float AngleRad = Mathf.Atan2(PlayerInfo.playerLocation.y - transform.position.y, PlayerInfo.playerLocation.x - transform.position.x);
        // Get Angle in Degrees
        float AngleDeg = (180 / Mathf.PI) * AngleRad;
        // Rotate Object
        fireballCopy.transform.rotation = Quaternion.Euler(0, 0, AngleDeg);

        //*make it so the fireball has starting velocity*

        fireballs ++; 
        
        if (fireballs == 3)
        {
            animator.SetInteger("whichAttack", 0);
            animator.SetBool("attackOver", true);
            fireballs = 0;
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(2);
        
    }
}
