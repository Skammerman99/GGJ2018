
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {

    public GameObject obj;

    private Vector3 pos1;
    private Vector3 pos2;
    public float speed = 0.1f;
    public float right_offset;
    public float left_offset;
    float timer = 0f;
    float lastPos = 0, currPos = 0;
    

    // Use this for initialization
    void Start () {

           pos1 = new Vector3(obj.transform.position.x - left_offset, obj.transform.position.y, obj.transform.position.z);
           pos2 = new Vector3(obj.transform.position.x + right_offset, obj.transform.position.y, obj.transform.position.z);
}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time/3 * speed, 1.0f));

        lastPos = currPos;
        currPos = transform.position.x;

        if(currPos >= lastPos)
        {
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
        }
        else
        {
            transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);

        }
    }
}

