using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMScript : MonoBehaviour {

    public AudioSource Source;
    public AudioClip BGM;
     

	// Use this for initialization
	void Start () {
        Source.PlayOneShot(BGM, 0.5F);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
