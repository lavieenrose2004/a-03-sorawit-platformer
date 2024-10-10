using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    public float speed = 4f;
    public int damage = 30;

    private void Start()
    {
        Move();
    }
 
    public override void Move()
    {
        // พิมพ์ข้อความเมื่อเรียกใช้ Move
        Debug.Log("Banana เคลื่อนที่ด้วย Transform ด้วยความเร็วคงที่");    
    }

    public override void OnHitWith(Character character)
    {
        
    }
}

