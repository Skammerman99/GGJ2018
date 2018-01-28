using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    public IEnumerator Fadery()
    {
        float fadeTime = GameObject.Find("GameManager").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        
    }

    public void SceneLoader(int SceneIndex)
     {

       Fadery();
       SceneManager.LoadScene(SceneIndex + 1);
    }

}
