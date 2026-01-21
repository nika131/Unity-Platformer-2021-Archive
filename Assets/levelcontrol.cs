using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelControlScript : MonoBehaviour
{
    public Button level02Button, level03button;
    int levelPassed;

    

    public void levelToLoad (int level)
    {
        SceneManager.LoadScene(level);
    }

    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        level02Button.interactable = false;
        level03button.interactable = false;

        switch (levelPassed)
        {
            case 1:
                level02Button.interactable = true;
                break;
            case 2:
                level02Button.interactable = true;
                level03button.interactable = true;
                break;
        }
    }
}
