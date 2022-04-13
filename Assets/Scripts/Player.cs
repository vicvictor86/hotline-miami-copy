using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;
    private Vector2 movement;
    private Rigidbody2D rbody;

    private Pointer pointer;
    private Vector2 mousePosition;

    private IGun gun;
    
    private void Awake()
    {
        gun = gameObject.AddComponent<Pistol>();
        pointer = GameObject.Find("Pointer").GetComponent<Pointer>();
        rbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Movement();
    }
    
    void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    public void Movement()
    {
        mousePosition = pointer.mousePosition;
        
        Vector2 loopDirection = mousePosition - rbody.position;
        float angle = Mathf.Atan2(loopDirection.y, loopDirection.x) * Mathf.Rad2Deg;

        rbody.rotation = angle;
        
        Vector2 currentPos = rbody.position;
 
        Vector2 adjustedMovement = movement * movementSpeed;
 
        Vector2 newPos = currentPos + adjustedMovement * Time.fixedDeltaTime;
 
        rbody.MovePosition(newPos);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(GetComponent("Pistol"));
        gun = gameObject.AddComponent<Shotgun>();
    }
}
