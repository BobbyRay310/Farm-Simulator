using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Cursor : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody rb;
    public Camera cam;

    Vector3 movement;
    Vector3 mousePos;
    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

     void FixedUpdate()
    {
        //rb.MovePosition(rb.position * moveSpeed * Time.fixedDeltaTime * movement);

        Vector3 lookDir = mousePos; //- rb.position;

        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;

        //rb.rotation = angle;
    }
}

/* public void Update()
    {
        Vector3 cursorpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(cursorpos.x, 0, cursorpos.z);
    }*/