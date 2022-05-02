using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pointer : MonoBehaviour
{
    
    private Camera camera;
    public Vector2 mousePosition;
    private Vector2 mousePositionPixel;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
    }

    void OnPointer(InputValue value)
    {
        mousePosition = camera.ScreenToWorldPoint(value.Get<Vector2>());
    }
    
    private void FixedUpdate()
    {
        transform.position = mousePosition;
    }
}
