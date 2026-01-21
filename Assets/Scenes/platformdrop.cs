using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformdrop : MonoBehaviour
{
    BoxCollider2D boxCollider;
    private Rigidbody2D rb;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            rb.gravityScale = 10f;
    }
}
