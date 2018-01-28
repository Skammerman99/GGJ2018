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

    public Vector3 start;
    float timer;

    public Sprite[] sprites;
    public float fps;
    private SpriteRenderer spriteRenderer;
    float xStart;

    public bool dead = false;

    public AudioSource ASource;
    public AudioClip walkClip;
    public AudioClip jumpClip;



    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().freezeRotation = true;
        spriteRenderer = GetComponent<Renderer>() as SpriteRenderer;
        start = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        ASource = GetComponent<AudioSource>();
        ASource.clip = walkClip;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        lvl_Zero = Physics2D.OverlapCircle(lvl_ZeroCheck.position, lvl_zeroRad, lvl_ZeroDef);
        wall_right = Physics2D.OverlapCircle(wall_check_right.position, wall_rad, wallDef);
        wall_left = Physics2D.OverlapCircle(wall_check_left.position, wall_rad, wallDef);

    }

    void Respawn()
    {

        gameObject.transform.position = start;
        dead = false;
    }

    void Update()
    {


        if (dead)
        {
            timer += Time.deltaTime;

            if (timer >= 0.75f)
            {
                Respawn();
                timer = 0;
            }
        }
        else
        {

            //animation
            int index = (int)(Time.timeSinceLevelLoad * fps);
            index = index % sprites.Length;


            //jumping
            if (Input.GetKeyDown(KeyCode.Space) && lvl_Zero || (Input.GetKeyDown(KeyCode.UpArrow) && lvl_Zero) || (Input.GetKeyDown(KeyCode.W) && lvl_Zero))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
                ASource.loop = false;
                ASource.PlayOneShot(jumpClip);
            }

            //moving forward
            else if (Input.GetKey(KeyCode.RightArrow) && !wall_right || (Input.GetKey(KeyCode.D) && !wall_right))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(movement, GetComponent<Rigidbody2D>().velocity.y);
                if (index == 0)
                {
                    index = 1;
                }
                spriteRenderer.sprite = sprites[index];
                spriteRenderer.flipX = false;

                if (lvl_Zero && GetComponent<Rigidbody2D>().velocity.y <= 0)
                {
                    if (!ASource.isPlaying)
                    {
                        ASource.loop = true;
                        ASource.PlayOneShot(walkClip);
                    }
                }
            }

            //moving backward
            else if (Input.GetKey(KeyCode.A) && !wall_left || (Input.GetKey(KeyCode.LeftArrow) && !wall_left))
            {

                GetComponent<Rigidbody2D>().velocity = new Vector2(-movement, GetComponent<Rigidbody2D>().velocity.y);
                if (index == 0)
                {
                    index = 1;
                }
                spriteRenderer.sprite = sprites[index];
                spriteRenderer.flipX = true;

                if (lvl_Zero && GetComponent<Rigidbody2D>().velocity.y <= 0)
                {
                    if (!ASource.isPlaying)
                    {
                        ASource.loop = true;
                        ASource.PlayOneShot(walkClip);
                    }
                }
            }

            else
            {
                spriteRenderer.sprite = sprites[0];
                if (GetComponent<Rigidbody2D>().velocity == new Vector2(0,0))
                {
                    ASource.Stop();
                }
            }
        }
    }
}
