using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finalscreen : MonoBehaviour
{
  public void PlayAgain()
    {
    Application.LoadLevel("Wave3");
    }

    // Update is called once per frame
    
   public void Menu()
    {
      Application.LoadLevel("start");

    }
}
