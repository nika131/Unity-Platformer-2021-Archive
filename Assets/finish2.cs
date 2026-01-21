using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish2 : MonoBehaviour
{
    public GameObject nextlevelUI;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
           
            nextlevekscreen();

        }


    }

    public void nextlevekscreen()
    {
        nextlevelUI.SetActive(true);
    }
}
