using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer_Disappear : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("LazerDestroy"))
        {
            Destroy(collision.gameObject);
        }

    }
}
