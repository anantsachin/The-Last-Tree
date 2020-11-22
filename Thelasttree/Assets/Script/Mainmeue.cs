using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainmeue : MonoBehaviour
{
    public void Start()
    {
      FindObjectOfType<AudioManager>().Play("Theme");

    }
    public void Playgame()
    {
     Application.LoadLevel("Wave1");
    }

    public void Quit()
    {
        Debug.Log("quitting...");
        Application.Quit();
    }
}

