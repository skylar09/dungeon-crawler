using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLvl : MonoBehaviour
{
    public Animator animator;
    public GameObject FadeOut;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            // nextLevel();
            StartCoroutine(fading());
        }
    }

    // public void nextLevel()
    // {
    //     StartCoroutine(fading());
    // }

    //fades the level out
    public IEnumerator fading()
    {
        FadeOut.SetActive(true);
        animator.SetBool("fadeOut", true);

        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log(PlayerInfo.playerHealth);
        Debug.Log(ShowPlayerHealth.health);       
    }
}
