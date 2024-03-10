using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tractor_KillBox : MonoBehaviour
{
    public ParticleSystem deathParticles;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Instantiate(deathParticles, transform.position, Quaternion.identity);

        }
    }

}
