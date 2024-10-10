using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    public Rigidbody2D rb2d;
    public Vector2 moveDirection;
    public float force = 10f;  
    public int damage = 40;

    private void Start()
    {
        Move();
    }
    public override void Move()
    {
        // ประกาศว่ากำลังเคลื่อนที่ด้วย RigidBody และใช้ force
        Debug.Log("Rock เคลื่อนที่ด้วย RigidBody: force");

    }

    public override void OnHitWith(Character character)
    {
        
    }
}

