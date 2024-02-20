﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    public float speed = 1f;
    public float increaseSpeed = 0.001f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed +=increaseSpeed* Time.deltaTime;
        transform.Translate(Vector2.left * speed);
    }
}