using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
  
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<enemy>(out enemy enemyComponent))
        {
            enemyComponent.TakeDamage(1);
        }

        Destroy(gameObject); // This destroys a game object when collision occurs

    }


}
