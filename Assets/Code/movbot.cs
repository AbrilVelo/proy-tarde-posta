using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movbot : MonoBehaviour
{


    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;
  
  
    public float moveSpeed = 3;
    public const string UP = "up";
    public const string DOWN = "down";

    string buttonPressed;
    private object hitInfo;

    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            buttonPressed = UP;
            transform.position += transform.up * (Time.deltaTime * 5);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            buttonPressed = DOWN;
            transform.position -= transform.up * (Time.deltaTime * 5);
        }
        else
        {
            buttonPressed = null;
        }
    }

    private void FixedUpdate()
    {

        if (buttonPressed == UP)
        {
            rb2d.AddForce(new Vector2(moveSpeed, 0), ForceMode2D.Force);
        }
        else if (buttonPressed == DOWN)
        {
            rb2d.AddForce(new Vector2(-moveSpeed, 0), ForceMode2D.Force);
        }
        }
    }
