using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : Enemy
{
    [SerializeField] private float attackRange;
    [SerializeField] private Player player;

    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private float bulletWaitTime;
    [SerializeField] private float bulletTimer;
   

    private void Start()
    {
        Init(100);       
    }

    private void Update()
    { 
        bulletTimer -= Time.deltaTime;

        Behaviour();

        
    }

    public override void Behaviour()
    {
        Vector3 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;

        if (distance < attackRange)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (bulletTimer < 0)
        {
            Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);

            bulletTimer = bulletWaitTime;
        }
    }

    
}
