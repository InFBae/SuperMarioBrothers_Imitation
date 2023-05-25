using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Controll : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float jumpPower;

    private Vector2 moveDir;
    private Rigidbody2D rd;

    private void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    private void Move() 
    {
        float h = Input.GetAxisRaw("Horizontal");
        rd.AddForce(Vector2.right * h * speed, ForceMode2D.Force);

        if (moveDir.x < 0 && rd.velocity.x < maxSpeed * (-1))
            rd.velocity = new Vector2(maxSpeed * (-1), rd.velocity.y);
        else if (moveDir.x > 0 && rd.velocity.x > maxSpeed)
            rd.velocity = new Vector2(maxSpeed, rd.velocity.y);
    }

    private void OnMove(InputValue value)
    {
        moveDir = value.Get<Vector2>();
    }

    private void Jump()
    {
        rd.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
    }

    private void OnJump()
    {
        Jump();
    }

}
