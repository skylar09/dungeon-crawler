using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossAttack : MonoBehaviour
{
    Animator animator;

    public GameObject Fireball;

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
        Instantiate(Fireball, bossBehavior.bossLocation , Quaternion.identity);
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
