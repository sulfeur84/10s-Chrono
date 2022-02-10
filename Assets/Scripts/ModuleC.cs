using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class ModuleC : MonoBehaviour
{
    
    public Renderer Voyant;
    public Material Vert;

    private int a, b;
    public TextMeshProUGUI aT, bT;
    private int True, False1, False2;
    public TextMeshProUGUI T1, F1, F2;

    public bool D, M, G;

    public void Awake()
    {
        a = Random.Range(1, 100);
        b = Random.Range(1, 100);

        aT.text = a.ToString();
        bT.text = b.ToString();

        if (G)
        {
            True = a + b;
            False1 = a + b + 1;
            False2 = a + b + 2;
        }
        if (M)
        {
            True = a + b;
            False1 = a + b - 1;
            False2 = a + b + 1;
        }
        if (D)
        {
            True = a + b;
            False1 = a + b - 1;
            False2 = a + b - 2;
        }

        T1.text = True.ToString();
        F1.text = False1.ToString();
        F2.text = False2.ToString();

    }

    public void InstantWin()
    {
        FindObjectOfType<AudioManager>().PitchAlea("Bip");
        if (!WinCondition.One) WinCondition.One = true; 
        else if (WinCondition.Four) WinCondition.Five = true; 
        else if (WinCondition.Three) WinCondition.Four = true; 
        else if (WinCondition.Two) WinCondition.Three = true; 
        else if (WinCondition.Two) WinCondition.Three = true; 
        else if (WinCondition.One) WinCondition.Two = true;
        Voyant.material = Vert;
    }
    public void Lose()
    {
        FindObjectOfType<AudioManager>().PitchAlea("Bip");
        Debug.Log("T NUL");
        Explosion.GameOver();
    }
}
