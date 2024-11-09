using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character, IShootable
{
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform BulletSpawnPoint { get; set; }
    public float BulletWaitTime { get; set; }
    public float BulletTimer { get; set; }
    public void Shoot()
    {
        //คลิกเม้าส์ซ้าย => shoot
        if (Input.GetButtonDown("Fire1") && (BulletTimer < 0)) 
        {
            Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
        }
    }

    private void Start()
    {
        Init(100);
    }

    private void Update()
    {
        Shoot(); 
    }

    private void FixedUpdate()
    {
        BulletTimer -= Time.deltaTime;
    }

}
