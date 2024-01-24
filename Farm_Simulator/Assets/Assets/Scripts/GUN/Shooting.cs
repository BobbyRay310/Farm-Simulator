using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using Unity.PlasticSCM.Editor.WebApi;

public class Shooting : MonoBehaviour
{
    public UnityEvent OnGunShoot;
    public float FireCooldown;

    public bool Automatic;

    private float CurrentCooldown;
    void Start()
    {

        CurrentCooldown = FireCooldown;

    }

    void Update()
    {
        if (Automatic)
        {
            if(CurrentCooldown <= 0f)
            {
                OnGunShoot?.Invoke();
                CurrentCooldown = FireCooldown;
            }
        }
        else
        {
            if (CurrentCooldown <= 0f)
            {
                OnGunShoot?.Invoke();
                CurrentCooldown = FireCooldown;
            }

        }

        CurrentCooldown -= Time.deltaTime;

    }

}
