using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaAnimacion : MonoBehaviour
{
    public Animator animator;
    public bool isJumping;
    public bool isDashing;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool jumpPressed = Input.GetKey(KeyCode.Space);
        bool dashPressed = Input.GetKey(KeyCode.LeftControl);

        if(jumpPressed)
        {
            animator.SetTrigger("Jump");
            isJumping = true;
        }
        else
        {
            isJumping = false;
        }

        if (dashPressed)
        {
            animator.SetBool("Dash", true);
            isDashing = true;
        }
        if(!dashPressed)
        {
            animator.SetBool("Dash", false);
            isDashing = false;
        }
    }
}
