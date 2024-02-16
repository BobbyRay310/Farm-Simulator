using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying_Spin : MonoBehaviour
{
    public GameObject player;

    public float speed = 1.5f;
    public float turnRate;
   
   private void Update()
    {
        Vector3 toTarget = player.transform.position - transform.position;
        float angleToTarget = Vector3.Angle(transform.forward, toTarget);

        transform.RotateAround(transform.position, Time.deltaTime * turnRate * angleToTarget);
        transform.Translate(toTarget * speed * Time.deltaTime);
    }
}
