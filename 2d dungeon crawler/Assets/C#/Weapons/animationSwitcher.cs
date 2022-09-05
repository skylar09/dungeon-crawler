using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationSwitcher : MonoBehaviour
{
    public GameObject player;

    public void endAnimation()
    {
        player.GetComponent<SwordAttack>().restartVariables();
    }
}