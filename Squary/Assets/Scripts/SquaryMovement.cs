using UnityEngine;

public class SquaryMovement : MonoBehaviour
{
    public Rigidbody2D rigidbodySquary;
    public float forwardForce;
    public float upForce;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatisGround;
    private bool onGround;

    void Start()
    {
        rigidbodySquary = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbodySquary.velocity = new Vector2(forwardForce, rigidbodySquary.velocity.y);

        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatisGround);

        //if (Input.touchCount > 0 && onGround)
        if (Input.GetKey("b") && onGround)
        {
            //rigidbodySquary.velocity = new Vector2(upForce, rigidbodySquary.velocity.x);
            rigidbodySquary.velocity = Vector2.up * upForce;
        }

        if ( rigidbodySquary.position.y < -2f)
            {
                FindObjectOfType<GameManager>().EndGame();
            }
    }
    
}
