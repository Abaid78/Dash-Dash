using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class AnimationsEvent : MonoBehaviour
{
    // This C# function can be called by an Animation Event
    public void DisableObject()
    {
        gameObject.SetActive(false);
    }public void EnableObject()
    {
        gameObject.SetActive(true);
    }
  
}
