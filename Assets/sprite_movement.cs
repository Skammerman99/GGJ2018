using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprite_movement : MonoBehaviour {

    public  float jumpHeight;
    public  float movement;
    public Transform lvl_ZeroCheck;
    public float lvl_zeroRad;
    public LayerMask lvl_ZeroDef;
    private bool lvl_Zero;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void FixedUpdate()
    {
        lvl_Zero = Physics2D.OverlapCircle(lvl_ZeroCheck.position, lvl_zeroRad, lvl_ZeroDef);
    }
	void Update () {
		
        if(Input.GetKeyDown (KeyCode.Space) && lvl_Zero)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(movement, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-movement, GetComponent<Rigidbody2D>().velocity.y);
        }
	}
}
