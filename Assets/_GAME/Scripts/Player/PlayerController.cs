using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Settings")]
    private float xValue, yValue;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float dashSpeed;

    [Header("Elements")]
    [SerializeField] private Rigidbody2D rb;


    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            xValue = Input.GetAxisRaw("Horizontal") * dashSpeed * Time.deltaTime;
            yValue = Input.GetAxisRaw("Vertical") * dashSpeed * Time.deltaTime;
            rb.velocity = new Vector2(xValue, yValue);

        }
        else
        {
            xValue = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
            yValue = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
            rb.velocity = new Vector2(xValue, yValue);

        }
    }
}
