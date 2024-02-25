using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{
    public int health;
    public int numberOfHearts;
    public int maxHealth;

    public Image[] hearts;
    public Sprite fullHearts;
    public Sprite emptyHeart;

    public GameObject prefab;
    public Player_Movement playermovent;
    public Timer time;
    void Update()
    {
        if (health > numberOfHearts)
        {
            health = numberOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].sprite = fullHearts;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numberOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

    }
    public void TakeDamage(int amount)
    {
        health -= amount; 
        if (health < 0)
        {
            prefab.SetActive(false);
            playermovent.enabled = false;
            time.enabled = false;

        }
    }

}
