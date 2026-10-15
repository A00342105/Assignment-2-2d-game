using UnityEngine;
using UnityEngine.InputSystem;

public class player_control : MonoBehaviour
{
    public Rigidbody2D rb;

    public float movespeed = 1;

    public Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + (moveInput * movespeed * Time.fixedDeltaTime));
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
}
