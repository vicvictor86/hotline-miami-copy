using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour, IGun
{
    // Start is called before the first frame update
    public GameObject BulletPrefab { get; set; }
    public Transform FirePoint { get; set; }
    public float BulletForce { get; set; }

    public virtual void Awake()
    {
        Shooting shooting = GetComponent<Shooting>();
        BulletPrefab = shooting.bulletPrefab;
        FirePoint = shooting.firePoint;
        BulletForce = shooting.bulletForce;
    }

    public void Shoot()
    {
        throw new NotImplementedException();
    }
}
