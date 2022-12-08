using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public GameObject Player, EventSystem, SpawnManager, Canvas;
    public Camera Camera;

    // Start is called before the first frame update
    void Start()
    {
        //makes it so all collisions on layers 6 (player) and 8 (weapon) are ignored
        Physics2D.IgnoreLayerCollision(6, 8, true);
        //makes it so enemies don't run into each other layer 7 is (enemies)
        Physics2D.IgnoreLayerCollision(7, 7, true);
        Physics2D.IgnoreLayerCollision(8, 9, true);
        Physics2D.IgnoreLayerCollision(7, 10, true);
        Physics2D.IgnoreLayerCollision(8, 10, true);
        Physics2D.IgnoreLayerCollision(9, 10, true);
        Physics2D.IgnoreLayerCollision(10, 10, true);
        DontDestroyOnLoad(Player);
        DontDestroyOnLoad(EventSystem);
        DontDestroyOnLoad(SpawnManager);
        DontDestroyOnLoad(Canvas);
        DontDestroyOnLoad(Camera);
    }
}
