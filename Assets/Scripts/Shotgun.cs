using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour, IGun
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
        Debug.Log(FirePoint.right);
        GameObject bullet = Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        GameObject bullet2 = Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation * Quaternion.Euler(0,90,0));
        GameObject bullet3 = Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation * Quaternion.Euler(0,-90,0));
        var rb = bullet.GetComponent<Rigidbody2D>();
        var rb2 = bullet2.GetComponent<Rigidbody2D>();
        var rb3 = bullet3.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint.right * BulletForce, ForceMode2D.Impulse);
        rb2.AddForce((FirePoint.right * new Vector2(1, (float) (Math.Sqrt(2)/2))) * BulletForce, ForceMode2D.Impulse);
        rb3.AddForce((FirePoint.right * new Vector2(1, (float) -(Math.Sqrt(2)/2))) * BulletForce, ForceMode2D.Impulse);
    }
}
