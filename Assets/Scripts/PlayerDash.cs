using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    // Velocità dello scatto
    public float dashSpeed = 20f;

    // Durata dello scatto
    public float dashDuration = 0.2f;

    // Tempo di ricarica dello scatto
    public float dashCooldown = 1f;

    private Rigidbody2D rb;
    public float dashTime;
    public float nextDashTime;
    public float dashtimePlatform;
    public bool dashed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashTime = 0f;
        nextDashTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        dashtimePlatform -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.LeftControl) && !dashed && dashtimePlatform >= 0f)
        {
            StartDash();
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && !dashed && dashtimePlatform >= 0f)
        {
            StartDash();
        }
    }
    void StartDash()
    {
        dashed = true;
        dashTime = dashDuration;
        nextDashTime = Time.time + dashCooldown;
        rb.velocity = new Vector2(dashSpeed, rb.velocity.y);
    }
}
