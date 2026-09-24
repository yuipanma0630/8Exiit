using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10.0f;

    private Rigidbody2D rb;

    private SpriteRenderer sr;

    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
    }

    private void Walk()
    {
        float direction = Input.GetAxisRaw("Horizontal");
        rb.linearVelocityX = direction * moveSpeed;

        if (direction > 0)
        {
            sr.flipX = false;
        }
        else if (direction < 0)
        {
            sr.flipX = true;
        }

        if (direction != 0)
        {
            anim.SetBool("Walk",true);
        }
        else
        {
            anim.SetBool("Walk",false);
        }
    }
}
