using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Pistol : Gun, IGun
{
    public new void Shoot()
    {
        var audio = gameObject.AddComponent<AudioSource>();
        var audioSource = GunShot.FirstOrDefault(gs => gs.name == "Pistol").audioSource;
        audio.clip = audioSource.clip;
        audio.Play();
        GameObject bullet = Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        var rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint.right * BulletForce, ForceMode2D.Impulse);
        
    }
}
