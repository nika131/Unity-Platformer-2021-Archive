using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelcontrol : MonoBehaviour
{
   
    

    

    public void levelToLoad (int level)
    {
        SceneManager.LoadScene(level);
    }



}
