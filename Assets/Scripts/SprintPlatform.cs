using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SprintPlatform : MonoBehaviour
{
    public float time;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerDash player = collision.GetComponent<PlayerDash>();
        player.dashed = false;
        player.dashtimePlatform = time;
    }
}