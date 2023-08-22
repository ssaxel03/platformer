using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    [SerializeField] private bool isJumping;
    private float horizontalAxis;

    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        Jump();
    }

    void Move() {
        horizontalAxis = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * horizontalAxis, rb.velocity.y);
    }

    void Jump() {
        if(Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpForce));
        }
    }

    private void OnCollisionEnter2D(Collision2D collider) {
        if(collider.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collider) {
        if(collider.gameObject.CompareTag("Floor"))
        {
            isJumping = true;
        }
    }
}
