using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    public Rigidbody2D rb2d;
    public Vector2 force;
    

    private void Start()
    {
        Damage = 20;
        force = new Vector2 (GetShootDirection() * 100, 400);
        Move();
    }
    public override void Move()
    {
        // ��С����ҡ��ѧ����͹������ RigidBody ����� force
        Debug.Log("Rock ����͹������ RigidBody: force");
        rb2d.AddForce(force, ForceMode2D.Impulse);
    }

    public override void OnHitWith(Character character)
    {
        if (character is Player)
        {
            character.TakeDamage(this.Damage);
        }
    }
}

