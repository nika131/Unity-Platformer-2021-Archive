using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savetransform : MonoBehaviour
{
    public Vector3 backtolevel2;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "portal")
        {

            backtolevel2 = transform.position;

        }


    }
}
