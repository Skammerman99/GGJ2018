using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boolet : MonoBehaviour {

    public float lifespan = 6f;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, lifespan);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Block")){
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Player"))
        {
           Destroy(other.gameObject);
           Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
