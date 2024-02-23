using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeadManager : MonoBehaviour
{
    public float speed = 0.1f;
    public float increaseSpeed = 0.001f;
    // Update is called once per frame
    void Update()
    {
        speed += increaseSpeed * Time.deltaTime;
        transform.Translate(Vector2.left * speed);
    }
}
