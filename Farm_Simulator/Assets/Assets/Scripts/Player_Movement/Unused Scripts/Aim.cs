using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField] private LayerMask groundMask;

    private Camera mainCamera;


    void Start()
    {
        mainCamera = Camera.main; //This activates the camera
    }

    private (bool success, Vector3 position) GetMousePosition() //This makes a Gameobject follow the mouse or the Player model moves
    {
        var ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out var hitInfo, Mathf.Infinity, groundMask))
        {
            return (success: true, position: hitInfo.point);
        }
        else
        {
            return (success: false, position: Vector3.zero);
        }

    }

    private void aim()
    {
        var (success, position) = GetMousePosition(); //This code is needed for the player to move otherwise it only goes up (for some reason)
        if (success)
        {
            var direction = position - transform.position;


            direction.y = 0; 

            transform.forward = direction;
        }
    }

}
