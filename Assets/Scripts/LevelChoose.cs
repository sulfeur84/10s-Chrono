using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChoose : MonoBehaviour
{
    public void BoopOnly()
    {
        SceneManager.LoadScene("BoopOnly");
    }
    public void Facile()
    {
        SceneManager.LoadScene("Facile");
    }
    public void Normal()
    {
        SceneManager.LoadScene("Normal");
    }
    public void Difficile()
    {
        SceneManager.LoadScene("Difficile");
    }
}
