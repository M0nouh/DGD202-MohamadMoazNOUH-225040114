using UnityEngine;

public class Movement : MonoBehaviour
{
    private float horizontal;
    private float speed = 10f;
    private bool rightlook = true;
    private float jumpboost = 10;

    public Rigidbody2D rb;
    public Transform ground;
    public LayerMask groundL;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsOnGround())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpboost);
        }

        if(Input.GetButtonUp("Jump")&& rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
        Flip();
    }


    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsOnGround()
    {
        return Physics2D.OverlapCircle(ground.position, 0.2f, groundL);
    }

    private void Flip()
    {
        if (rightlook && horizontal < 0f || !rightlook && horizontal > 0f)
        {
            rightlook = !rightlook;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
