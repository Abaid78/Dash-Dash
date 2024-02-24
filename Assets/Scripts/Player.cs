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
    public UIManager uiManager;
    public int coins;
    public Animator animator;
    void Update()
    {
        if (isGrounded || extraJumps > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = Vector2.up * jumpForce;
                animator.SetBool("Jump",true);
                isGrounded = false;
                extraJumps--;

            }
        }
        //Quit the Application
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            animator.SetBool("Jump", false);
            extraJumps = maxExtraJumps;
        }
        if (collision.gameObject.CompareTag("Coin"))
        {
            coins += 1;
            uiManager.CoinCountUpdateUI(coins);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Obstrical"))
        {
           
        }
    }

}
