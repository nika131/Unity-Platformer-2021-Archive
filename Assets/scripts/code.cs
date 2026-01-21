using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code : MonoBehaviour
{
    [SerializeField] protected float damage;
    CircleCollider2D boxCollider;

    private void Start()
    {
        boxCollider = GetComponent<CircleCollider2D>();
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            collision.GetComponent<health>().TakeDamage(damage);
    }
}
