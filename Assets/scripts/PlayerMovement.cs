using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public  float jumpHeight;
    public  float movement;
    public Transform lvl_ZeroCheck;
    public float lvl_zeroRad;
    public LayerMask lvl_ZeroDef;
    private bool lvl_Zero;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().freezeRotation = true;
        
		
	}
	
	// Update is called once per frame
    void FixedUpdate()
    {
        lvl_Zero = Physics2D.OverlapCircle(lvl_ZeroCheck.position, lvl_zeroRad, lvl_ZeroDef);
    }
	void Update () {
//jumping
        if(Input.GetKeyDown (KeyCode.Space) && lvl_Zero)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && lvl_Zero)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }
        if (Input.GetKeyDown(KeyCode.W) && lvl_Zero)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }
        //moving forward
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(movement, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(movement, GetComponent<Rigidbody2D>().velocity.y);
        }
        //moving backward
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-movement, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-movement, GetComponent<Rigidbody2D>().velocity.y);
        }
    }
}
