using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moyai_HitBox : MonoBehaviour
{
    public Heart health;
    public int damage;
    public ParticleSystem deathParticles;
   /* private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            health.TakeDamage(1);
        }
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy();
        }
    }

    public void Destroy()
    {
        Instantiate(deathParticles, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
