using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public Heart health;
    public int damage;

    [SerializeField] private AudioSource hurtSFX;
 
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            health.TakeDamage(1);
           // hurtSFX.Play();
        }
    }
}
