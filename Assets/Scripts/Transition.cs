using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour {

    public Texture2D fadeOutTexture;     //Texture Overlay on Screen
    public float fadeSpeed = 0.8f;      //Fade Speed

    private int drawDepth = -1000;
    private float alpha = 1.0f;
    private int fadeDir = -1;

    void OnGUI()
    {
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
    }
}
