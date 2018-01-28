using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

    public Sprite[] sprites;
    public float fps;
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start () {
        spriteRenderer = GetComponent<Renderer>() as SpriteRenderer;
    }
	
	// Update is called once per frame
	void Update () {
        int index = (int)(Time.timeSinceLevelLoad * fps);
        index = index % sprites.Length - 1;
        spriteRenderer.sprite = sprites[index];
	}
}
