using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pendulum : MonoBehaviour
{
    Rigidbody2D rb;

    public float moveSpeed;
    public float leftAngle;
    public float rightAngle;

    bool moveingClockwise;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveingClockwise = true;
    }

    
    void Update()
    {

        Move();
    }

    public void ChangeMoveDir()
    {
        if (transform.rotation.z > rightAngle)
        {
            moveingClockwise = false;
        }
        if (transform.rotation.z < leftAngle)
        {
            moveingClockwise = true;
        }

    }

    public void Move()
    {
        ChangeMoveDir();

        if (moveingClockwise)
        {
            rb.angularVelocity = moveSpeed;
        }

        if (!moveingClockwise)
        {
            rb.angularVelocity = -1*moveSpeed;
        }
    }
}
