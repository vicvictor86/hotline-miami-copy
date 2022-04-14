using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Gun, IGun
{
    public new void Shoot()
    {
        int angle = 7;
        CreateBullet(0);
        CreateBullet(angle);
        CreateBullet(-angle);
    }

    private void CreateBullet(int angle)
    {
        Quaternion rotation = Quaternion.Euler(0, 0, angle);
        GameObject bullet = Instantiate(BulletPrefab, FirePoint.position, rotation * FirePoint.rotation);
        var rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(rotation * FirePoint.right * BulletForce, ForceMode2D.Impulse);
    }
}
