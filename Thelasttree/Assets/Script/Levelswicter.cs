using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Levelswicter : MonoBehaviour
{
  public GameObject[] enemies;

  void Update()
{
    enemies = GameObject.FindGameObjectsWithTag("Enemy"); // Checks if enemies are available with tag "Enemy". Note that you should set this to your enemies in the inspector.
    if (enemies.Length == 0)
    {
        Debug.Log("yasss");
        Time.timeScale = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
}
