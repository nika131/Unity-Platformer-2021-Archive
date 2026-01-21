using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityStandardAssets.CrossPlatformInput;



public class gravitychange : MonoBehaviour
{
    BoxCollider2D boxCollider;
    private Rigidbody2D rb;
    private bool top;
    private PlayerController player;

    private void Start()
    {
        player = GetComponent<PlayerController>();
        boxCollider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if (transform.position.x > 312.5 && top == false)
        {
            rb.gravityScale = -5f;
            Rotation();
        }
        else if(transform.position.x > 380 && top == true)
        {
            rb.gravityScale = 5f;
            
        }

        if (transform.position.x > 380 && top == true)
        {
            Rotation();
            rb.gravityScale = 5f;
            
        }
    }

    

    void Rotation()
    {
        if (top == false)
        {
            transform.eulerAngles = new Vector3(0, 0, 180f);
        }
        else 
        {
            transform.eulerAngles = Vector3.zero;
        }
        player.facingRight = !player.facingRight;
        top = !top;
        
    }


}


