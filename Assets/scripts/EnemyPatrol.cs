using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D boxCollider;

    [SerializeField] private float f;
    [SerializeField] private float damage;
    [SerializeField] public float speed ;
    [SerializeField] private float s;

    
    public LayerMask groundLayers;

    public Transform groundCheck;

    bool isFacingRight = true;

    RaycastHit2D hit;

    private float dazeTime;
    public float startDazedTime;

    public int health;

    private Animator anim;
    public GameObject bloodEffect;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        hit = Physics2D.Raycast(groundCheck.position, -transform.up, 1f, groundLayers);

        if (dazeTime <= 0)
        {
            speed = s;
        }
        else
        {
            speed = 0;
            dazeTime -= Time.deltaTime;

        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        if (hit.collider != false)
        {
            if (isFacingRight)
            {
                rb.velocity = new Vector2(-speed, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(speed, rb.velocity.y);
            }
        }
        else
        {
            isFacingRight = !isFacingRight;
            transform.localScale = new Vector3(-transform.localScale.x, f, f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<health>().TakeDamage(damage);
        }
    }

   

    public void TakeDmage(int damage)
    {
        Instantiate(bloodEffect, transform.position, Quaternion.identity);
        dazeTime = startDazedTime;
        health -= damage;
        anim.SetTrigger("hurt");
    }
}
