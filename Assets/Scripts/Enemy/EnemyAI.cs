using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyAI : MonoBehaviour
{

    private Vector3 startPosition;
    private Vector3 roamPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        roamPosition = GetRoamingPosition();
    }

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GetRandomDirection()
    {
        return new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }

    private Vector3 GetRoamingPosition()
    {
        return startPosition + GetRandomDirection() * Random.Range(10f, 70f);
    }
}
