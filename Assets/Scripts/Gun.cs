using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour, IGun
{
    
    public GameObject BulletPrefab { get; set; }
    public Transform FirePoint { get; set; }
    public float BulletForce { get; set; }

    public List<AudioName> GunShot { get; set; }

    public virtual void Awake()
    {
        Shooting shooting = GetComponent<Shooting>();
        BulletPrefab = shooting.bulletPrefab;
        FirePoint = shooting.firePoint;
        BulletForce = shooting.bulletForce;
        GunShot = shooting.audios;
    }

    public void Shoot()
    {
        throw new NotImplementedException();
    }
}
