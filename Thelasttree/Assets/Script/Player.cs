using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
 public GameObject EndscreenUI;
	public int maxHealth = 100;
	public int currentHealth;
	public int damaging = 4;
	
	

	public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    { 
         Time.timeScale = 1;
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
   {
		//if (Input.GetKeyDown(KeyCode.Space))
		//{
			//TakeDamage(20);
		//}

 if (currentHealth <= 0)
         {
             //Die
             
EndscreenUI.SetActive(true);
         Time.timeScale = 0;
         }
	}
    
	void OnCollisionEnter2D(Collision2D _collision)
	{
      if (_collision.gameObject.tag=="Enemy")
	  {
		  currentHealth -= damaging;
		  Debug.Log("Enemy is damaging...");
		  healthBar.SetHealth(currentHealth);
	  }

	}

	 void Die()
     {
         Destroy(gameObject);
		
     }
     


	//public void TakeDamage(int damage)
//	{
//		currentHealth -= damage;

	//	healthBar.SetHealth(currentHealth);
	//}
}
