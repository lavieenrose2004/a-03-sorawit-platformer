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
        // ������ͤ�����������¡�� Move
        Debug.Log("Banana ����͹������ Transform ���¤������Ǥ����");    
    }

    public override void OnHitWith(Character character)
    {
        
    }
}

