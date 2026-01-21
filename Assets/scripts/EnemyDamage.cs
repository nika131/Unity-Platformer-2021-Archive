using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] protected float damage;
    BoxCollider2D boxCollider;

    private void Start()
    {
      boxCollider = GetComponent<BoxCollider2D>();
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            collision.GetComponent<health>().TakeDamage(damage);
    }
}
