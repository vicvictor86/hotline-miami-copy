using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGun
{
    public GameObject BulletPrefab { get; set; }
    public Transform FirePoint { get; set; }
    public float BulletForce { get; set; }

    public int BulletCount { get; set; }
    
    void Shoot();
}
