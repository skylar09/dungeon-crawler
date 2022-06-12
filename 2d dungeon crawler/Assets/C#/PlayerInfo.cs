using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{

    public static int playerHealth = 3;
    public static int playerDamage = 5;
    public static int playerDefense = 3;
    public static float movementSpeed = .004f;
    public static Vector3 playerLocation;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        playerLocation = new Vector3(player.GetComponent<Transform>().position.x, player.GetComponent<Transform>().position.y, player.GetComponent<Transform>().position.z);
        // Debug.Log(playerLocation);
        
    }
}
