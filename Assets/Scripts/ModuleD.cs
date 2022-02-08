using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class ModuleD : MonoBehaviour
{
    public TextMeshProUGUI TextCount;
    public int ToGo, Do;

    public bool Done;
    
    public Renderer Voyant;
    public Material Vert;

    public void Start()
    {
        ToGo = Random.Range(5, 20);
        TextCount.text = ToGo.ToString();
    }

    public void Add1()
    {
        FindObjectOfType<AudioManager>().Play("Boop");
        Do += 1; 
    }

    public void Update()
    {
        if (Do == ToGo && !Done)
        {
            Win();
            Done =  true;
        }
        
        if(Do > ToGo) Lose();
    }
    
    public void Win()
    {
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
        Debug.Log("T NUL");
        Explosion.GameOver();
    }
}
