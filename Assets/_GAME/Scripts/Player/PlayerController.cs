using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Settings")]
    private float xValue, yValue;
    [SerializeField] private float moveSpeed;

    [Header("Elements")]
    [SerializeField] private Rigidbody2D rb;


    private void FixedUpdate()
    {
        xValue = Input.GetAxisRaw("Horizontal") * moveSpeed*Time.deltaTime;
        yValue = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
        rb.velocity= new Vector2(xValue,yValue);
    }
}
