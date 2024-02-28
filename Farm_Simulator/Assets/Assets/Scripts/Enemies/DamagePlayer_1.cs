using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer_1 : MonoBehaviour
{
    public Heart_1 health;
    public int damage;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            health.TakeDamage(1);
        }
    }
}
