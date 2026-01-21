using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingspike : MonoBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D boxCollider;
    public float distance;
    bool isFalling = false;
    [SerializeField] protected float damage;
    [SerializeField] protected float GS;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        Physics2D.queriesStartInColliders = false;
        if(isFalling == false)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distance);

            Debug.DrawRay(transform.position, Vector2.down * distance, Color.red);

            if(hit.transform != null)
            {
                if (hit.transform.tag == "Player")
                {
                    rb.gravityScale = GS;
                    isFalling = true;
                }
            }
           
        }
    }
    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            collision.GetComponent<health>().TakeDamage(damage);
    }
}
