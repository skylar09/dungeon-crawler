using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endAttack : MonoBehaviour
{
    public void endAnimation()
    {
        Weapons.canAttack = true;
        Weapons.swordSwung = false;
    }
}
