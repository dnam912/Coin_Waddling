using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

// Code Reference: 
// https://youtu.be/82U4ToJU-28?si=fForx8Vh5MpmTAkX

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    
    private Rigidbody2D rb;
    private Vector2 movement;
    private Animator animator;


    public GameManagement gameManager; // Connect to the GameManagement Script
    private bool isDead; // Define whether the player is dead or not


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = movement * moveSpeed;


        // if (collected all of them && bool isdead)
        // {dead}
        /* private void OnTriggerEnter2D(Collider2D other)
        {
            if (CoinCounter.coinCounter >= 20 && isDead)
            {
                isDead = true;
                gameManager.gameOver(); // Game Over
                Debug.Log("Dead");
            }
        }*/
    }

    

    public void Move(InputAction.CallbackContext context)
    {
        animator.SetBool("isWalking", true);

        if (context.canceled)
        {
            animator.SetBool("isWalking", false);
            animator.SetFloat("moveX", movement.x);
            animator.SetFloat("moveY", movement.y);
        }
        movement = context.ReadValue<Vector2>();
        animator.SetFloat("moveX_Walk", movement.x);
        animator.SetFloat("moveY_Walk", movement.y);
    }

    public void Die(InputAction.CallbackContext context)
    {
        animator.SetBool("isDead", true);
    }

}
