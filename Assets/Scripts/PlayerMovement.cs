using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] MainCharacterController controller;
    [SerializeField] float horizontalMovement = 0f;
    [SerializeField] float movementSpeed = 40f;
    [SerializeField] bool isJumping = false;

    [Header("Dash")]
    [SerializeField] private float dashVelocity = 14f;
    [SerializeField] private float dashTime = 0.5f;
    private Vector2 dashDirection;
    private bool isDashing;
    private bool canDash;

    public Rigidbody2D rb;



    // Update is called once per frame
    void Update()
    {
        var dashInput = Input.GetButtonDown("Dash");

        horizontalMovement = Input.GetAxisRaw("Horizontal") * movementSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
            isDashing = false;
            canDash = true;
            Debug.Log("Jumping");
        }   

        if (dashInput && canDash)
        {
            isDashing = true;
            canDash = false;
            dashDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            if(dashDirection == Vector2.zero)
            {
                dashDirection = new Vector2(transform.localScale.x, 0);
            }

            StartCoroutine(stopDash());
        }

        if (isDashing)
        {
            rb.velocity = dashDirection.normalized * dashVelocity;
        }

    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMovement * Time.fixedDeltaTime, false, isJumping);
        isJumping = false;
    }

    private IEnumerator stopDash()
    {
        yield return new WaitForSeconds(dashTime);
        isDashing = false;
    }

    
    
}
