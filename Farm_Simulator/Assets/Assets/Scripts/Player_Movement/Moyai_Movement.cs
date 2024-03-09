using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Moyai_Movement : MonoBehaviour
{
    Moyai controls;

    Vector2 move;

    Vector2 rotate;

     void Awake()
    {
        controls = new Moyai();

        controls.MOAI.Grow.performed += ctx => Grow();
        
        controls.MOAI.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.MOAI.Move.canceled += ctx => move = Vector2.zero;

        controls.MOAI.Rotation.performed += ctx => rotate = ctx.ReadValue<Vector2>();
        controls.MOAI.Rotation.canceled += ctx => rotate = Vector2.zero;

    }

    void Grow()
    {
        transform.localScale *= 1.1f;
    }

    private void Update()
    {
        Vector2 m = new Vector2(move.x, move.y) * Time.deltaTime;
        transform.Translate(m, Space.World);

        Vector2 r = new Vector2(-rotate.y, -rotate.x) * 100f * Time.deltaTime;
        transform.Rotate(r, Space.World);
    }

    void OnEnable()
    {
        controls.MOAI.Enable();
    }
    void OnDisable()
    {
        controls.MOAI.Disable();
    }


}
