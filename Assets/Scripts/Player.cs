using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float jumpForce = 10f;
    public Rigidbody2D rb;
    public bool isGrounded = false;
    public int extraJumps = 1;
    public int maxExtraJumps = 1;
    private void Start()
    {
       
    }
    void Update()
    {
        if (isGrounded || extraJumps > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = Vector2.up * jumpForce;
                isGrounded = false;
                extraJumps--;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            extraJumps = maxExtraJumps;
        }
    }

}
