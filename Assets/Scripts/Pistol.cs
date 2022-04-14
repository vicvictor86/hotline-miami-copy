using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Gun, IGun
{
    public void Shoot()
    {
        GameObject bullet = Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        var rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint.right * BulletForce, ForceMode2D.Impulse);
    }
}
