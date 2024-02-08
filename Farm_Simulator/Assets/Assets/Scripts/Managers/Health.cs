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

    void TakeDamage(int amount)
    {
        currentHealth -= amount;

  /*      if(currentHealth < 0)
        {

       } */
    }

    void Heal(int amount)
    {
        currentHealth += amount;
        {
            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        TakeDamage(currentHealth);
      
    }


}
