using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleA : MonoBehaviour
{
    public bool One, Two, Three, Four;
    public Renderer Voyant;
    public Material Vert;

    public void ButtonOne()
    {
        One = true;
        FindObjectOfType<AudioManager>().PitchAlea("Bip");
    }
    public void ButtonTwo()
    {
        FindObjectOfType<AudioManager>().PitchAlea("Bip");
        if(One)Two = true;
        else Lose();
    }
    public void ButtonThree()
    {
        FindObjectOfType<AudioManager>().PitchAlea("Bip");
        if(One && Two)Three = true;
        else Lose();
    }
    public void ButtonFour()
    {
        FindObjectOfType<AudioManager>().PitchAlea("Bip");
        if (One&&Two&&Three)
        {
            Win();
        } else Lose();
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
