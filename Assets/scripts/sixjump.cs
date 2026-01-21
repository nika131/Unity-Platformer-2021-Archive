using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sixjump : MonoBehaviour
{
    private PlayerController player;
    

    private void Start()
    {
        player = GetComponent<PlayerController>();
        
    }

    void Update()
    {
        if (transform.position.x > 302.5)
        {
            player.extraJumpsValue = 5;
        }
        else if (transform.position.x > 345)
        {
            player.extraJumpsValue = 1;
        }
        
        
    }
}
