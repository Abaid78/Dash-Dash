using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AspectRatioManager : MonoBehaviour
{
    public GameObject player;
    float minX;
    private Vector3 initialSize; public Camera mainCamera;
    private void Start()
    {
        minX = mainCamera.ViewportToWorldPoint(new Vector2(0f, 0f)).x;
        player.transform.position = new Vector2(minX+2, player.transform.position.y);
    }
   
}
