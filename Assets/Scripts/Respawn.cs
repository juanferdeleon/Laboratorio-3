using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    private void OnCollisionEnter(Collision collision)
    {
        Sphere sphere = collision.gameObject.GetComponent<Sphere>();
        if (sphere.Coins() < 3) {
            player.transform.position = respawnPoint.transform.position;
        }
    }
}
