using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilitycontrol : MonoBehaviour
{
    public GameObject sphereTrigger;
    public static bool canUse = true;
    public GameObject shadow;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && canUse == true){
            triggersphere.pos = PlayerInfo.playerLocation;
            //makes and sets a destroy timer for .5 seconds on a sphereTrigger
            Destroy(Instantiate(sphereTrigger, PlayerInfo.playerLocation, Quaternion.identity), .5f);
            canUse = false;
            shadow.SetActive(true);
        }
    }
}
