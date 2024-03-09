using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Destroy_Lazer : MonoBehaviour
{
  /*  private void Awake()
    {
        StartCoroutine(waiter());
    }


    IEnumerator waiter()
    {
        yield return new WaitForSeconds(3);
        Object.Destroy(this.gameObject);
    }*/
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "LazerDestroy")
        {
            Destroy(collision.gameObject);
        }

    }

}
