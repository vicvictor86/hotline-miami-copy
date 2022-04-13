using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour, IGun
{
    public GameObject BulletPrefab { get; set; }
    public Transform FirePoint { get; set; }
    public float BulletForce { get; set; }

    private void Awake()
    {
        Shooting shooting = GetComponent<Shooting>();
        BulletPrefab = shooting.bulletPrefab;
        FirePoint = shooting.firePoint;
        BulletForce = shooting.bulletForce;
    }

    public void Shoot()
    {
        GameObject bullet = Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        var rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint.right * BulletForce, ForceMode2D.Impulse);
    }
}
