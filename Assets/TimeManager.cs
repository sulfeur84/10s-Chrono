using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public GameObject PostPro;
    public void OnMouseEnter()
    {
        PostPro.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void OnMouseExit()
    {
        PostPro.gameObject.SetActive(true);
        Time.timeScale = 0.2f;
    }
}
