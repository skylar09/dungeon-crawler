using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationSwitcher : MonoBehaviour
{
    public GameObject player;
    
    SwordAttack attackScript;

    // Start is called before the first frame update
    void Start()
    {
        attackScript = player.GetComponent<SwordAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void endAnimation()
    {
        attackScript.resetWeapon();
    }
}
