using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLvl : MonoBehaviour
{
    //public Animator animator;
    public GameObject FadeOut;
    public GameObject glow;
    public GameObject text;
    //public GameObject Camera;

    // Update is called once per frame
    void Update()
    {
        //makes pillar glow
        glow.SetActive(true);
        //if player is within 3 units of the pillar
        if (Vector2.Distance(PlayerInfo.playerLocation, this.transform.position) < 3)
        {
            //turns on text
            //text.SetActive(true);
            
            if (Input.GetKeyDown("z"))
            {
                StartCoroutine(fading());
            }
        }
        else
        {
            text.SetActive(false);
        }
    }

    //fades the level out
    public IEnumerator fading()
    {
        FadeOut.SetActive(true);
        //animator.SetBool("fadeOut", true);

        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
        PlayerCollision.currentRoom = 0;
        FadeOut.SetActive(false);
    }
}
