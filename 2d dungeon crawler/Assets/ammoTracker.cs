using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ammoTracker : MonoBehaviour
{
   public TextMeshProUGUI ammoNum;

    void Awake(){
        ammoNum.text = PlayerInfo.ammo.ToString() + " | 10";
    }

    public void updateAmmo(){
        ammoNum.text = PlayerInfo.ammo.ToString() + " | 10";
    }
}
