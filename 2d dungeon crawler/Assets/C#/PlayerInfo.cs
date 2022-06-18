using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{

    public static int playerHealth = 3;
    public static int playerDamage = 1;
    public static int playerDefense = 1;
    public static float movementSpeed = 3f;
    public static float swordSwingSpeed;
    public static Vector3 playerLocation;
    public GameObject player;
    public static string directionFacing = "right";

    // Start is called before the first frame update
    void Start()
    {
        swordSwingSpeed = 0.08f * Screen.height * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        //sets playerLocation equal to the current location
        playerLocation = new Vector3(player.GetComponent<Transform>().position.x, player.GetComponent<Transform>().position.y, player.GetComponent<Transform>().position.z);
        // Debug.Log(playerLocation);
        
    }
}
