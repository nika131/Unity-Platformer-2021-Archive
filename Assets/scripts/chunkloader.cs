using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chunkloader : MonoBehaviour
{
   
    public GameObject[] Objects;

    Rigidbody2D rb;
    BoxCollider2D boxCollider;
    public float distance;
    bool isFalling = false;
    

  

    private void Update()
    {
        Physics2D.queriesStartInColliders = false;
        if (isFalling == false)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distance);

            Debug.DrawRay(transform.position, Vector2.down * distance, Color.red);

            if (hit.transform != null)
            {
                if (hit.transform.tag == "Player")
                {
                    
                    isFalling = true;

                    


                }
                
            }

        }
    }
   
}
    

