using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {

    private Vector3 pos1 = new Vector3(-4, 0, 0);
    private Vector3 pos2 = new Vector3(4, 0, 0);
    public float speed = 0.01f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time/3 * speed, 1.0f));
    }
}
