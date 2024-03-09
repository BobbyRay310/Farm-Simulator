using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moyai_HitBox : MonoBehaviour
{
    public Heart health;
    public int damage;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            health.TakeDamage(1);
        }
    }
}
