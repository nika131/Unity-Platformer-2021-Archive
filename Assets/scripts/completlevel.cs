using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class completlevel : MonoBehaviour
{
    int sceneIndex, levelPassed;


    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("levelPassed");
    }

    public void YouWin()
    {
        if (sceneIndex == 3)
            Invoke("LoadMenu", 1f);
        else
        {
            if (levelPassed < sceneIndex)
                PlayerPrefs.SetInt("levelPassed", sceneIndex);
        }
    }

    

    private void LoadMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
