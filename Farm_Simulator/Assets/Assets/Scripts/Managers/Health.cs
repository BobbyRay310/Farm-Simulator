using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth; //This makes the currentHealth = to maxHealth
        

    }

    void TakeDamage(int amount) //This decreases the player's current health
    {
        currentHealth -= amount;

  /*      if(currentHealth < 0)
        {

       } */
    }

    void Heal(int amount) //This grants the player the ability to heal
    {
        currentHealth += amount;
        {
            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }
        }


    }

    private void OnCollisionEnter(Collision collision) //If the player collides with enemy players they take damage
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            TakeDamage(currentHealth);

        }

    }


}
