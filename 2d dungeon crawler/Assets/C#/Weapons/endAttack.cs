using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endAttack : MonoBehaviour
{
    //resets attack variables
    //this is needed in different script so that at the end of attack animation it can auto call this method
    public void endAnimation()
    {
        Weapons.canAttack = true;
        Weapons.swordSwung = false;
    }
}
