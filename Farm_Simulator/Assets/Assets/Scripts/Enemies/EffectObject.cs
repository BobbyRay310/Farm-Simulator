using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectObject : MonoBehaviour
{

    [SerializeField] private AudioSource dyingSFX;
    public float time;
    void Start()
    {
        Destroy(gameObject, time);
        dyingSFX.Play();
    }

}
