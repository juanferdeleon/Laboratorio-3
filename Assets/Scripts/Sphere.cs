using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{

    public Rigidbody rigidbody;

    public int force = 10;

    private int ctr = 0;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rigidbody.velocity.y) < 0.05f)
        {
            Jump();
        }
    }
    void FixedUpdate()
    {
        rigidbody.AddForce(Input.GetAxis("Horizontal") * force, 0, Input.GetAxis("Vertical") * force);

    }

    private void Jump()
    {
        rigidbody.AddForce(Vector3.up * force, ForceMode.Impulse);
    }

    public void IncrementCtr() {
        ctr++;
        Debug.Log("Contador de monedas: " + ctr);
    }

    public int Coins()
    {
        return ctr;
    }
}
