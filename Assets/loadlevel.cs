using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadlevel : MonoBehaviour
{
  
    public void levelToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }
}
