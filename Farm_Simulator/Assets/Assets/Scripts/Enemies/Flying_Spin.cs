using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Flying_Spin : MonoBehaviour
{
  //  public Transform toTarget;
    public GameObject player;

    public float speed = 1.5f;
    public float turnRate;
   
   private void Update()
    {
     //   Vector3 toTarget = this.transform.position, target;
        Vector3 toTarget = player.transform.position - transform.position;
        float angleToTarget = Vector3.Angle(transform.forward, toTarget);
        //direction.Normalize(Direction dir);

        transform.RotateAround(this.transform.position, Time.deltaTime * turnRate * angleToTarget);
        transform.Translate(toTarget * speed * Time.deltaTime);
    }
}
