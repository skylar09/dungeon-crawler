using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilitycontrol : MonoBehaviour
{
    public GameObject sphereTrigger;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e")){
            triggersphere.pos = PlayerInfo.playerLocation;
            Instantiate(sphereTrigger, PlayerInfo.playerLocation, Quaternion.identity);
        }
    }
}
