using Assets.Scripts;
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

    public List<AudioName> audios;

    public UIManager UIManager;

    private void Start()
    {
        UIManager.UpdateBullet();
    }

    private void Update()
    {
        gun = GetComponent<IGun>();
    }

    void OnShoot(InputValue value)
    {
        if (gun.BulletCount > 0)
        {
            gun.Shoot();
            UIManager.UpdateBullet();
        }
    }

}
