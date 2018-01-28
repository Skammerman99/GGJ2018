using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_of_Deletion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
   
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerMovement>().dead = true;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
