using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Wall : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public GameObject healthBar;
    private Slider healthSlider;

    private void Start()
    {
        currentHealth = maxHealth;
        GameObject healthBarObject = Instantiate(healthBar, transform.position + new Vector3(0, 2, 0), Quaternion.identity);
        healthBarObject.transform.SetParent(transform);
        healthSlider = healthBarObject.GetComponentInChildren<Slider>();

        UpdateHealthBar();
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        UpdateHealthBar();

        if (currentHealth <= 0)
        {
            Destroy(healthSlider.gameObject);
            Destroy(gameObject);
        }
    }
    private void UpdateHealthBar()
    {
        if (healthSlider != null)
        {
            healthSlider.value = (float)currentHealth / maxHealth;
            healthSlider.GetComponentInChildren<Text>().text = currentHealth.ToString();
        }
    }

}

//public class HealthSystem
//{
//    private int health;
//    private int healthMax;
//    public HealthSystem(int healthMax)
//    {
//        this.healthMax = healthMax;
//        health = healthMax;
//    }
//    public int GetHealth()
//    {
//        return health;
//    }
//    public void Damage(int damageAmount)
//    {
//        health -= damageAmount;
//        if (health < 0) health = 0;
//    }
//}
