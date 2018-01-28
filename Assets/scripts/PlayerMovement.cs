using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float jumpHeight;
    public float movement;
    public Transform lvl_ZeroCheck;
    public float lvl_zeroRad;
    public LayerMask lvl_ZeroDef;
    private bool lvl_Zero;
    public Transform wall_check_right;
    public Transform wall_check_left;
    public float wall_rad;
    public LayerMask wallDef;
    public bool wall_left;
    public bool wall_right;


    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().freezeRotation = true;


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        lvl_Zero = Physics2D.OverlapCircle(lvl_ZeroCheck.position, lvl_zeroRad, lvl_ZeroDef);
        wall_right = Physics2D.OverlapCircle(wall_check_right.position, wall_rad, wallDef);
        wall_left = Physics2D.OverlapCircle(wall_check_left.position, wall_rad, wallDef);

    }
    void Update()
    {
        //jumping
        if (Input.GetKeyDown(KeyCode.Space) && lvl_Zero)
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
        if (Input.GetKey(KeyCode.RightArrow) && !wall_right)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(movement, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKey(KeyCode.D) && !wall_right)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(movement, GetComponent<Rigidbody2D>().velocity.y);
        }
        //moving backward
        if (Input.GetKey(KeyCode.LeftArrow) && !wall_left)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-movement, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKey(KeyCode.A) && !wall_left)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-movement, GetComponent<Rigidbody2D>().velocity.y);
        }
    }
}
