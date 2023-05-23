using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float moveSpeed;

    public float jumpForce;
    public KeyCode jumpButton = KeyCode.Space;
    private Rigidbody2D rb;
    public bool isOnGround = true;

    private SpriteRenderer sr;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime * horizontalInput);
        //flip the sprite if facing left
        if (horizontalInput > 0)
        {
            sr.flipX = false;
        }
        else if (horizontalInput < 0)
        {
            sr.flipX = true;
        }


        horizontalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime * horizontalInput);
        //flip the sprite if facing left
        if (horizontalInput > 0)
        {
            sr.flipY = false;
        }
        else if (horizontalInput < 0)
        {
            sr.flipY = true;
        }


        if (Input.GetKeyDown(jumpButton) && isOnGround)
        {
            isOnGround = false;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            Debug.Log("Force Added");

        }


    }
}
