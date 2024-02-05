using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Control : MonoBehaviour
{
    Vector3 lookPos;
  
    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //This follows the Mouse's placement on Screen

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            lookPos = hit.point;

        }

        Vector3 lookDir = lookPos - transform.position;
        lookDir.y = 0;

        transform.LookAt(transform.position + lookDir, Vector3.up);
    }
}
