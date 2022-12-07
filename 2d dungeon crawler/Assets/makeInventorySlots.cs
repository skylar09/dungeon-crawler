using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class makeInventorySlots : MonoBehaviour
{
    public GameObject slot;

    // Start is called before the first frame update
    public void makeSlots(GameObject player)
    {
        for (int i = 0; i < 18; i ++){
            GameObject x = Instantiate(slot, new Vector3(0, 0, 0), Quaternion.identity, transform);
            player.GetComponent<InventoryItems>().InventorySlots.Add(x.transform.GetChild(0).GetChild(0).gameObject.GetComponent<Image>());
        }   
    }
}
