using UnityEngine;
using UnityEngine.AI;
public class FarmerMovement : MonoBehaviour
{

    public Transform target;
    private NavMeshAgent agent;

    void Start()
    {
        agent.GetComponent<NavMeshAgent>();
    }

    void Find(Vector3 location)
    {
        agent.SetDestination(location);

        Vector3 fleevector = agent.transform.position + location;
        agent.SetDestination(this.transform.position + fleevector);

    }

 
    void Update()
    {
        Find(target.transform.position);
        //agent.destination = target.position;
    }
}
