﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCollision : MonoBehaviour {


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer==LayerMask.NameToLayer("Pipe")||collision.gameObject.layer== LayerMask.NameToLayer("Ground"))
        {
            Debug.LogError("与"+collision.gameObject.name +"碰撞了");
            GameMananager.Instance.GameOver();
        }
    }
}
