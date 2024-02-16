using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(menuName = "Brain/Chase")]
public class ChaseBrain : Brain
{
    public string targetTag;
    public override void Think(EnemyThinker thinker)
    {
        GameObject target = GameObject.FindGameObjectWithTag(targetTag);
        if (target)
        {
            var movement = thinker.gameObject.GetComponent<Enemies_Follow>();
            if(movement)
            {
                movement.Follow();
            }
        }
    }
}
