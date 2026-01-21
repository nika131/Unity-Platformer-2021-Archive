using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    private GameMaster gm;

    void Start()
    {
        GameObject gmObject = GameObject.FindGameObjectWithTag("GM");

        if (gmObject == null)
        {
            UnityEngine.Debug.LogError("Error: Could not find an object with tag 'GM' in the scene.");
        }
        else
        {
            gm = gmObject.GetComponent<GameMaster>();

            if (gm == null)
            {
                UnityEngine.Debug.LogError("Error: The object tagged 'GM' does not have the 'GameMaster' script attached!");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gm.lastCheckPointPos = transform.position;
            
        }
    }


}
