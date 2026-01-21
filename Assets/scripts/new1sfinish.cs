 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class new1sfinish : MonoBehaviour
{

    private savetransform backtolevel2;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {

            nextlevekscreen();

        }


    }
    

    

    public void nextlevekscreen()
    {
        SceneManager.LoadScene("new2");
        
    }
}
