using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Mechanic : MonoBehaviour
{
    public bool Shoot;
    public ParticleSystem bullet;
    void Update() //This emits a particle effect (Has not been used)
    {
        if (Input.GetMouseButton(0))
        {
            bullet.Emit(1);
        }
    }
}
