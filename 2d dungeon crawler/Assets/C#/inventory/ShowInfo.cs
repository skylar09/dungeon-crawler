using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowInfo : MonoBehaviour{
    public TextMeshProUGUI damage;

    void Awake(){
        //gotta figure out how to get the damage of the item in the slot to then pass to the text
        //int x = this.GetComponent<>();

        //damage.text = x.ToString();
    }
}
