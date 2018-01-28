using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRestrictions : MonoBehaviour {
    public GameObject left;
    public GameObject right;
    public GameObject player;

    


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(player.transform.position.x > right.transform.position.x)
        {
            transform.position = new Vector3(right.transform.position.x, transform.position.y, transform.position.z);
        }else if(player.transform.position.x < left.transform.position.x)
        {
         transform.position = new Vector3(left.transform.position.x, transform.position.y, transform.position.z);
        }
        else {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);                }
	}
}
