using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 10f;
    public Rigidbody2D rb;
    public bool isGrounded = false;
    public int extraJumps = 1;
    public int maxExtraJumps = 1;
    public int threshold = 100;
    public UIManager uiManager;
    private int coins;
    public Animator animator;
    public AudioSource audioSource;

    private void Update()
    {
        if (isGrounded || extraJumps > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = Vector2.up * jumpForce;
                animator.SetBool("Jump", true);
                isGrounded = false;
                extraJumps--;
            }
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            animator.SetBool("Jump", false);
            extraJumps = maxExtraJumps;
        }
        if (collision.gameObject.CompareTag("Coin"))
        {
            IncreaseAndSaveCoins();
            audioSource.Play();
            uiManager.UpdateCoinCountUI(coins);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Obstrical"))
        {
        }
    }
    void IncreaseAndSaveCoins()
    {
        coins += 1;

        // Load the previously saved number of coins
        int savedCoins = SaveData.GetCoins();

        // If coins are greater than the saved coins, update and save them
        if (coins > savedCoins)
        {
            SaveData.SaveCoins(coins);
        }

        // Check the coins threshold
        CheckCoinsThreshold(coins, threshold);
    }

  void CheckCoinsThreshold(int coins, int threshold)
    {
        // Check if the coins reached a multiple of the threshold
        if (coins % threshold == 0)
        {
            // Perform the action
            Debug.Log("Performing action after every " + threshold + " coins: " + coins);
        }
    }
}