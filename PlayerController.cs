using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CharacterController), typeof(Animator))]
public class PlayerController : MonoBehaviour
{
    public CinemachineVirtualCamera vcam;
    
    private CharacterController characterController;
    private Animator animator;

    [SerializeField]
    private float movementSpeed, rotationSpeed, jumpSpeed, gravity;

    private Vector3 movementDirection = Vector3.zero;
    public static bool playerGrounded;
    private bool justLanded;

    public static bool inputEnabled = true;

    public AudioSource jumpSound;
    public AudioSource LandJumpSound;


    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if (inputEnabled)
        {
            
            playerGrounded = characterController.isGrounded;

            //movement
            Vector3 inputMovement = transform.forward * movementSpeed * Input.GetAxisRaw("Vertical");
            characterController.Move(inputMovement * Time.deltaTime);

            transform.Rotate(Vector3.up * Input.GetAxisRaw("Horizontal") * rotationSpeed);


            //jumping
            if (Input.GetButton("Jump") && playerGrounded)
            {
                
                movementDirection.y = jumpSpeed;
                jumpSound.Play();
            }
            if (!playerGrounded)
            {
                movementDirection.y -= gravity * Time.deltaTime;
            }

            //landing

            if (playerGrounded)
            {
                if (!justLanded)
                {
                    justLanded = true;
                    LandJumpSound.Play();
                }
            }
            else
            {
                justLanded = false;
            }

            


            characterController.Move(movementDirection * Time.deltaTime);


            //animations
            animator.SetBool("isRunning", Input.GetAxisRaw("Vertical") != 0);
            animator.SetBool("isJumping", !characterController.isGrounded);
            animator.SetBool("isFalling", LevelDeath.falling);

        }
        else
        {
            animator.SetBool("isRunning", false);
            animator.SetBool("isJumping", false);
        }
    }
}