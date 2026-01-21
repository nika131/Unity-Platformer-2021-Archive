using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    [SerializeField] private Transform levelPart_1;


   private void Awake()
    {
       

        Instantiate(levelPart_1, new Vector3(26, -2), Quaternion.identity);
    }
}
