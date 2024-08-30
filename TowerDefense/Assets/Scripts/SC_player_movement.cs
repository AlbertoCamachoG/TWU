using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_player_movement : MonoBehaviour
{
    public float movSpeed;
    [SerializeField] private Rigidbody2D rb;
    private Vector2 moveDirection;

    // Update is called once per frame
    void Update()
    {
        GetInput();
        

    }

    private void FixedUpdate()
    {
        // Physics Calculations
        Move();

    }
    void GetInput()
    {
        float moveX = Input.GetAxisRaw("Horizontal") * movSpeed;
        float moveY = Input.GetAxisRaw("Vertical") * movSpeed;

        moveDirection = new Vector2(moveX, moveY).normalized;
    }
    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * movSpeed, moveDirection.y * movSpeed);
    }
}
