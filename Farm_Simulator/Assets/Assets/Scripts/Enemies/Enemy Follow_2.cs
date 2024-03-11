using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow_2 : MonoBehaviour
{
    public Transform targetObj;
    void Update()
     {

         transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, 5 * Time.deltaTime);

     }
}
