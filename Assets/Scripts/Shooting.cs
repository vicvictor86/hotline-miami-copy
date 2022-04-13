using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform firePoint;

    public float bulletForce = 20f;
    private IGun gun;

    private void Update()
    {
        gun = GetComponent<IGun>();
    }

    void OnShoot(InputValue value)
    {
        gun.Shoot();
    }

}
