using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Controller : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private BoxCollider2D boxCollider2d;

    Vector2 input;

    public float speed;
    public float jumpVelocity = 4f;
    private bool lookLeft = true;
    bool pause = false;
    public GameObject PauseMenuCanvas;
    public int health = 2;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Alive();
        Move();
        Jump();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pause)
            {
                OpenPauseMenu();
            }
            else if (pause)
            {
                ClosePauseMenu();
            }
        }
    }

    void Move()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb2D.velocity = new Vector2(moveInput * speed, rb2D.velocity.y);

        Orientation(moveInput);
    }

    void Orientation(float moveInput)
    {
        if ((lookLeft == true && moveInput < 0) || (lookLeft == false && moveInput > 0))
        {
            lookLeft = !lookLeft;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }

    private void Jump()
    {
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.velocity = Vector2.up * jumpVelocity;
        }
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down * .1f);
        return raycastHit2d.collider != null;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bot")
        {
            health--;
            Debug.Log("Contacto");

            Debug.Log(health);
            
        }
    }

    private void Alive()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("Muerto");
            Debug.Log("Muerto");
        }
    }

    public void OpenPauseMenu()
    {
        GameManager.Instance.PauseGame();
        PauseMenuCanvas.SetActive(true);
        pause = true;
    }

    public void ClosePauseMenu()
    {
        GameManager.Instance.ResumeGame();
        PauseMenuCanvas.SetActive(false);
        pause = false;
    }

}
