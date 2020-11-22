using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
   public int currentHealth;
    public GameObject pickupEffect;
    public int increasehealth = 20;
public int multiplier = 2;

  void OnTriggerEnter2D (Collider2D other)
{
   if (other.CompareTag("Player"))
 {
  Pickup(other);
 }
}

   void Pickup(Collider2D player)
 {
 Instantiate(pickupEffect, transform.position, transform.rotation);
 FindObjectOfType<AudioManager>().Play("Run");
 Player stats = player.GetComponent<Player>();
 currentHealth = stats.currentHealth;
 stats.currentHealth *= multiplier;
 stats.healthBar.SetHealth(currentHealth);

 
 Destroy(gameObject);
 
 
 }
}

