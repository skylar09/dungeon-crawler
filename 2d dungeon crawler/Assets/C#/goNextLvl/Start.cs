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

    public IEnumerator fading()
    {
        FadeOut.SetActive(true);
        animator.SetBool("fadeOut", true);

        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // PlayerInfo.swordSwingSpeed = (float).00127 *  Screen.height * Time.deltaTime;
        Debug.Log(Screen.height);
    }
}
