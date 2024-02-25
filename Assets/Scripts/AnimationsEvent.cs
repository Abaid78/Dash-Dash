using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class AnimationsEvent : MonoBehaviour
{
    // This C# function can be called by an Animation Event
    public void DisableThisObject()
    {
        Debug.Log("Disable Object");
    }
    private void Start()
    {
        
    }
}
