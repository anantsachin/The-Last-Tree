using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endscreeb : MonoBehaviour
{
    // Start is called before the first frame update
   public void PlayAgain()
    {
    Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }

    // Update is called once per frame
    
   public void Menu()
    {
      Application.LoadLevel("start");

    }
}