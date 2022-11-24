using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightningstrike : MonoBehaviour
{
    public void makeLightning(Vector2 pos){
        GameObject bolt = Instantiate(this.gameObject, PlayerInfo.playerLocation, Quaternion.identity);
       
        float posX = PlayerInfo.playerLocation.x - pos.x;
        float posY = PlayerInfo.playerLocation.y - pos.y;
        float angle = Mathf.Atan2(posY, posX) * Mathf.Rad2Deg;

        if (posX > 0)
            bolt.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 90 - angle));
        else
            bolt.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));

    }
}
