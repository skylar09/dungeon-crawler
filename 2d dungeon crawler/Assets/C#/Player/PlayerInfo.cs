using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInfo : MonoBehaviour
{
    //all of the players stats
    public static int playerHealth = 3;
    public static int playerDamage = 1;
    public static int playerDefense = 0;
    public static float movementSpeed = 3f;
    public static int critChance = 0;
    public static int gold = 0;
    public static int ammo = 10;
    public static float swordSwingSpeed = 1;
    public static Vector3 playerLocation;
    public static string directionFacing = "left";
    
    // Update is called once per frame
    void Update()
    {
        //sets playerLocation equal to the current location
        playerLocation = this.transform.position;
    }
}
