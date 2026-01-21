using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creditfinish : MonoBehaviour
{
    private AudioSource finishSound;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            finishSound.Play();
            
            Invoke("craditload", 1f);
        }


    }

    void craditload()
    {
        SceneManager.LoadScene("cradit");
    }
}
