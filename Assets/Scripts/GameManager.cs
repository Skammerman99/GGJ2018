using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Image black;//IMage
    public Animator anim;

    public IEnumerator Fadery()
    {
        float fadeTime = GameObject.Find("GameManager").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        
    }//Get rid of

        

    IEnumerator Fadding()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
    }



    public void SceneLoader(int SceneIndex)
     {
       StartCoroutine(Fadding());
       Fadery();
       SceneManager.LoadScene(SceneIndex + 1);
    }

}
