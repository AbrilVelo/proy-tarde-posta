using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento2 : MonoBehaviour
{


    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;

    public float moveSpeed = 3;

    public const string RIGHT = "right";
    public const string LEFT = "left";

    string buttonPressed;

    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            buttonPressed = RIGHT;
            transform.position += transform.right * (Time.deltaTime * 5);
            transform.localScale = new Vector3(1f, 1f, 1f);
            animator.SetBool("caminando", true);

        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            buttonPressed = LEFT;
            transform.position -= transform.right * (Time.deltaTime * 5);
            transform.localScale = new Vector3(-1f, 1f, 1f);
            animator.SetBool("caminando", true);
        }
        else
        {
            buttonPressed = null;
            animator.SetBool("caminando", false);
        }
    }

    private void FixedUpdate()
    {

        if (buttonPressed == RIGHT)
        {
            rb2d.AddForce(new Vector2(moveSpeed, 0), ForceMode2D.Force);
        }
        else if (buttonPressed == LEFT)
        {
            rb2d.AddForce(new Vector2(-moveSpeed, 0), ForceMode2D.Force);
        }
    }
}