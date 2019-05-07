using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    [SerializeField]
    List<PatrolPoints> patrolPoints;

    NavMeshAgent navMeshAgent;
    int patrolIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (navMeshAgent.transform.position != patrolPoints[patrolIndex].transform.position)
        {
            setDestination();
            Debug.Log("Hola mundofasdfasdfasdf");
        }

    }

    private void setDestination() {
        Vector3 targetVector = patrolPoints[patrolIndex].transform.position;
        navMeshAgent.SetDestination(targetVector);
        if (navMeshAgent.remainingDistance <= 1.0f) {
            ChangePatrolPoint();
        }
    }

    private void ChangePatrolPoint() {
        patrolIndex = (patrolIndex + 1) % patrolPoints.Count;

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sphere") {
            Destroy(other.gameObject);
        }
    }
}
