using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleB : MonoBehaviour
{
    public Renderer Voyant;
    public Material Vert;

    public void InstantWin()
    {
        FindObjectOfType<AudioManager>().Play("Boop");
        if (!WinCondition.One) WinCondition.One = true; 
        else if (WinCondition.Four) WinCondition.Five = true; 
        else if (WinCondition.Three) WinCondition.Four = true; 
        else if (WinCondition.Two) WinCondition.Three = true; 
        else if (WinCondition.Two) WinCondition.Three = true; 
        else if (WinCondition.One) WinCondition.Two = true;
        Voyant.material = Vert;
    }
}
