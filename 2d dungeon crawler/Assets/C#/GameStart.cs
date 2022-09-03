using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    bool ignore = true;

    // Start is called before the first frame update
    void Start()
    {
        //makes it so all collisions on layers 6 (player) and 8 (weapon) are ignored
        Physics2D.IgnoreLayerCollision(6, 8, ignore);
        //makes it so enemies don't run into each other layer 7 is (enemies)
        Physics2D.IgnoreLayerCollision(7, 7, ignore);
    }
}
