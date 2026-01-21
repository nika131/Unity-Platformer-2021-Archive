using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerback : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "back")
        {

            transform.position = new Vector2(121, 5);

        }


    }

   
}
