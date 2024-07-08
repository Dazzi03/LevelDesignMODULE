using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityChanger : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Vector2 playerVelocity;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<Rigidbody2D>().velocity = playerVelocity;
    }
}
