using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilityShadow : MonoBehaviour
{
    public void Off(){
        abilitycontrol.canUse = true;
        this.gameObject.SetActive(false);
    }
}
