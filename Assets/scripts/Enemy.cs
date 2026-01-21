using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public GameObject bloodEffect;

    private float dazeTime;
    public float startDazedTime;

    void Update()
    {
       
        if(health <= 0)
        {
            Destroy(gameObject);
        }
     
    }
    public void TakeDmage(int damage)
    {
        dazeTime = startDazedTime;
        
        
        health -= damage;Instantiate(bloodEffect, transform.position, Quaternion.identity);

    }

   
}
