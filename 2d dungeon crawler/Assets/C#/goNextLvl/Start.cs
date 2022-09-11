using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public Animator animator;
    public GameObject FadeOut;

    public void nextLevel()
    {
        StartCoroutine(fading());
    }

    //makes the screen fade black
    public IEnumerator fading()
    {
        FadeOut.SetActive(true);
        animator.SetBool("fadeOut", true);

        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene(pauseMenu.whichScene);
    }
}
