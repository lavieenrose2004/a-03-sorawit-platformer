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
        // ��С����ҡ��ѧ����͹������ RigidBody ����� force
        Debug.Log("Rock ����͹������ RigidBody: force");

    }

    public override void OnHitWith(Character character)
    {
        
    }
}

