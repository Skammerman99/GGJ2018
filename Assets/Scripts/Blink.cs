using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour {

    public float coolDown = 5;
    float timer = 0f;
    bool ready = true;
    int direction = 1;
    
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {

        if (!ready) {
            timer += Time.deltaTime;
            if (timer >= 1.5)
            {
                ready = true;
                timer = 0;
            } 
        }

   
           
        if(Input.GetKeyDown (KeyCode.LeftArrow) )
        {
            direction = -1;
        }else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = 1;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            direction = -1;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            direction = 1;
        }

        if (Input.GetKeyDown (KeyCode.Q) && ready)
        {
            blinking(direction);
            if (ready)
            {
                ready = false;
            }
        }
       

    }
    void blinking(int direction)
    {
        //transform.Translate( current.x + (3 * direction);
        //Debug.Log("Blink");
        transform.position = new Vector3(transform.position.x + (3 * direction), transform.position.y, transform.position.z);
    }
    
    

    
}
