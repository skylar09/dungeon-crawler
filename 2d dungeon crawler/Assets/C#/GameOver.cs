using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public GameObject gameOverText;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (PlayerInfo.playerHealth <= 0)
        {
            //sets movement speed to 0 and turns on game over text
            PlayerInfo.movementSpeed = 0;
            gameOverText.SetActive(true);
            // animator.SetBool("PlayerDead", true);
        }
    }
}
