using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelscript : MonoBehaviour
{
    public void Pass()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
    
        if(currentLevel >= PlayerPrefs.GetInt("levelanlocked"))
        {
            PlayerPrefs.SetInt("levelanlocked", currentLevel + 1);
        }
          

    }

}
