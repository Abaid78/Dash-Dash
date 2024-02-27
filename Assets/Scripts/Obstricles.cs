using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstricles: MonoBehaviour
{
    public SpeadManager speadManager;
    private void Start()
    {
        speadManager = FindObjectOfType<SpeadManager>();
    }
    void Update()
    {
        transform.Translate(Vector2.left * speadManager.speed *Time.deltaTime);
    }
}
