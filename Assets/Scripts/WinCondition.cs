using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public static bool One, Two, Three, Four, Five;
    public bool OneWin, TwoWin, ThreeWin, FiveWin;

    public void Start()
    {
        One = false;
        Two = false;
        Three = false;
        Four = false;
        Five = false;
    }

    public void Update()
    {
        if (ThreeWin)
        {
            if (One && Two && Three) SceneManager.LoadScene("Win");
        }

        if (OneWin)
        {
            if (One) SceneManager.LoadScene("Win");
        }

        if (TwoWin)
        {
            if (One && Two ) SceneManager.LoadScene("Win");
        }

        if (FiveWin)
        {
            if (One && Two && Three && Four && Five) SceneManager.LoadScene("Win");
        }
    }
}
