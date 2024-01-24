using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diagonal_Fix : MonoBehaviour
{

    float moveX = 0f;
    float moveZ = 0f;

    void Start()
    {
     //   if(Input.GetKeyDown(KeyCode.W)) 

        Vector3 moveDir = new Vector3(moveX, moveZ).normalized;
        float moveSpeed = 20f;
        transform.position += moveDir * moveSpeed * Time.deltaTime;


    }

    void Update()
    {
        
    }
}
