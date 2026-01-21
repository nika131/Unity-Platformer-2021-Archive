using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rb;

    public bool facingRight = true;

    private bool isGrounded;
    public Transform groundcheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    private bool blk;
    public int extraJumpsValue;

    private Animator anim;

    public ParticleSystem dust;

    [SerializeField] private AudioSource jumpSoundEffect;

    public GameObject GameOverUI;

    
    

    void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        blk = false;
        
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundcheck.position, checkRadius, whatIsGround);

        moveInput = CrossPlatformInputManager.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (facingRight == false && moveInput > 0)
        {
            Flip();
            CreteDust();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
            CreteDust();
        }
    }

    void Update()
    {
        if(isGrounded)
        {
            extraJumps = extraJumpsValue;
            
        }
        

        if (rb.gravityScale > 0)
        {
            if (CrossPlatformInputManager.GetButtonDown("Jump") && isGrounded)
            {
                rb.velocity = Vector2.up * jumpForce;
                extraJumps = -1;
                jumpSoundEffect.Play();
                blk = true;
                CreteDust();
            }
            else if (CrossPlatformInputManager.GetButtonDown("Jump") && extraJumps >= 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                if (blk)
                {
                    extraJumps--;
                }
                extraJumps--;
                CreteDust();

                blk = false;
                jumpSoundEffect.Play();
            }
        }

        if (rb.gravityScale < 0)
        {
            if (isGrounded)
            {
                extraJumps = extraJumpsValue;
            }
            if (CrossPlatformInputManager.GetButtonDown("Jump") && isGrounded)
            {
                rb.velocity = Vector2.down * jumpForce;
                extraJumps = -1;
                blk = true;
                CreteDust();
                jumpSoundEffect.Play();

            }
            else if (CrossPlatformInputManager.GetButtonDown("Jump") && extraJumps >= 0)
            {
                rb.velocity = Vector2.down * jumpForce;
                if (blk)
                {
                    extraJumps--;
                }
                extraJumps--;
                CreteDust();
                blk = false;
                jumpSoundEffect.Play();

            }

        }
            anim.SetBool("walk", moveInput != 0);

        Invoke("restartLevel", 2f);

       
    }

    public void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scale = transform.localScale;
        Scale.x *= -1;
        transform.localScale = Scale;
        
    }

    void CreteDust()
    {
        dust.Play();
    }

    private void restartLevel()
    {
        if (transform.position.y < -10)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

        else if (transform.position.y > 53)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }


    }
}
    

  