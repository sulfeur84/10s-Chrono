using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public static bool One, Two, Three;

    public void Start()
    {
        One = false;
        Two = false;
        Three = false;
    }

    public void Update()
    {
        if (One && Two && Three) SceneManager.LoadScene("Win");
    }
}
