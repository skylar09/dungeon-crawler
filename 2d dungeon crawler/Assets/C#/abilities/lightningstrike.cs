using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightningstrike : MonoBehaviour
{
    public Camera camera;

    public void makeLightning(Vector2 pos1, Vector2 pos2){
        GameObject bolt = Instantiate(this.gameObject, new Vector3(pos1.x, pos1.y, 0), Quaternion.identity);
        Destroy(bolt, 1.5f);
       
        float posX = pos1.x - pos2.x;
        float posY = pos1.y - pos2.y;
        float angle = Mathf.Atan2(posY, posX) * Mathf.Rad2Deg;

        if (posX > 0)
            bolt.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 90 - angle));
        else
            bolt.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));

        //Vector2 size = bolt.GetComponent<SpriteRenderer>().sprite.rect.size;

        Vector3 pixels = camera.WorldToScreenPoint(new Vector3(posX, posY, 0));
        pixels = new Vector3(pixels.x / 128, pixels.y / 120, 1);
        pixels = camera.ScreenToWorldPoint(pixels);

        bolt.transform.localScale = pixels;

        triggersphere.pos = pos2;
    }
}
