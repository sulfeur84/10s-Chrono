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
    }
    public void ButtonTwo()
    {
        if(One)Two = true;
        else Lose();
    }
    public void ButtonThree()
    {
        if(One && Two)Three = true;
        else Lose();
    }
    public void ButtonFour()
    {
        if (One&&Two&&Three)
        {
            Win();
        } else Lose();
    }

    public void Win()
    {
        Debug.Log("Ta gagné");
        Voyant.material = Vert;
    }

    public void Lose()
    {
        Debug.Log("T NUL");
    }
}
