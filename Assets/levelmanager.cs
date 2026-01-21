using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelmanager : MonoBehaviour
{
    int levellocked;

    public Button[] Buttons;

    void Start()
    {
        levellocked = PlayerPrefs.GetInt("levelanlocked", 1);

        for (int i = 0; i < Buttons.Length; i++)
        {
            Buttons[i].interactable = false;
        }
        for (int i = 0; i < levellocked; i++)
        {
            Buttons[i].interactable = true;
        }
    }

}
