using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInfo : MonoBehaviour
{

    public static int playerHealth = 3;
    public static int playerDamage = 1;
    public static int playerDefense = 0;
    public static float movementSpeed = 3f;
    public static int gold = 0;

    public static float swordSwingSpeed = 1;
    public static Vector3 playerLocation;
    public static string directionFacing = "right";

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //sets playerLocation equal to the current location
        playerLocation = new Vector3(this.GetComponent<Transform>().position.x, this.GetComponent<Transform>().position.y, this.GetComponent<Transform>().position.z);
        // Debug.Log(playerLocation);     
    }
}
