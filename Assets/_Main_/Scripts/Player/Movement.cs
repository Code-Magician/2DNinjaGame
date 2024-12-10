using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] KeyCode jumpKey;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator animator;

    [Header("Movement Data")]
    [SerializeField]
    [Range(1f, 100f)] float speed;
    [SerializeField]
    [Range(1f, 1000f)] float jumpForce;

    private bool isGrounded = false;


    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        Vector3 currScale = transform.localScale;
        if(x < 0)
        {
            currScale.x = -1;
            transform.localScale = currScale;
            animator.SetBool("isRunning", true);
        }
        else if (x > 0)
        {
            currScale.x = 1;
            transform.localScale = currScale;
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        transform.Translate(Vector2.right * x * speed * Time.deltaTime, Space.Self);

        if(isGrounded && Input.GetKeyDown(jumpKey))
        {
            isGrounded = false;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}
