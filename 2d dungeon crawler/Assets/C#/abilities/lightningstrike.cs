using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightningstrike : MonoBehaviour
{
    //makes a lightning bolt starting at pos1 and going to pos2
    public void makeLightning(Vector2 pos1, Vector2 pos2){
        //makes and then sets a destroy timer for 1.5 seconds on the lightning bolt
        GameObject bolt = Instantiate(this.gameObject, new Vector3(pos1.x, pos1.y, 0), Quaternion.identity);
        Destroy(bolt, 1.5f);
       
        //difference between the two positions
        float posX = pos1.x - pos2.x;
        float posY = pos1.y - pos2.y;
        //angle between the objects
        float angle = Mathf.Atan2(posY, posX) * Mathf.Rad2Deg;

        //rotates the lightning bolt so it faces pos2
        if (posX > 0)
            bolt.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 90 - angle));
        else
            bolt.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));

        //gets the distance between the positions and then sets the scale of the lightning bolt based on them
        float hypot = Mathf.Sqrt(Mathf.Pow(posX, 2) + Mathf.Pow(posY, 2)) / 1.2f;
        bolt.transform.localScale = new Vector3(4, hypot, 1);

        //sets next triggersphere position to pos2
        triggersphere.pos = pos2;
    }
}
