using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies_Follow : MonoBehaviour
{

    public Transform targetObj;
    void Update()
    {

        transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, 10 * Time.deltaTime);

    }
}
