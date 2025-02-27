using UnityEngine;

public class Climb : MonoBehaviour
{
    public float climbSpeed = 3f;
    public bool isClimbing = false;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ladder"))
        {
            isClimbing = true;
            rb.gravityScale = 0f;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Ladder"))
        {
            isClimbing = false ;
            rb.gravityScale = 1f;
        }
    }
    private void FixedUpdate()
    {
        if (isClimbing)
        {
            float climbInput = Input.GetAxisRaw("Vertical");
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, climbInput * climbSpeed);
        }
    }
}
