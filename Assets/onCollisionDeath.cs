using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollisionDeath : MonoBehaviour {

    
    
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        
    }
            
            // Use this for initialization
            void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
