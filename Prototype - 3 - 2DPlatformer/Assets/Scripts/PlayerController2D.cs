using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController2D : MonoBehaviour
{
    [Header("Player Settings")]
    public float moveSpeed;
    public float jumpForce;
    public bool isGrounded;
    public int bottomBound = -4;
    [Header("Score")]
    public int score;

    public Rigidbody2D rig;
    public TextMeshProUGUI scoreText;

void Start()
    {
        isGrounded = true;
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }


void FixedUpdate ()
{
    float moveInput = Input.GetAxisRaw("Horizontal");
    rig.velocity = new Vector2(moveInput * moveSpeed, rig.velocity.y);
}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            Debug.Log("Player is jumping");
            isGrounded = false;
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        if(transform.position.y < bottomBound)
        {
            GameOver();
        }
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        Debug.Log("Player is touching ground");
        if(collision.GetContact(1).normal == Vector2.up)
        {
            Debug.Log("Player is grounded");
            isGrounded = true;
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
