using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{

    public Camera camera;
    public NavMeshAgent navMeshAgent;
    public Rigidbody rigidbody;
    private int ctr = 0;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                navMeshAgent.SetDestination(hit.point);
            }
        }
    }

    public void IncrementCtr() {
        ctr++;
        Debug.Log("Contador de monedas: " + ctr);
        score.text = "Score: " + ctr;
    }

    public int Coins()
    {
        return ctr;
    }
}
