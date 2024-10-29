using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoorBehaviour : MonoBehaviour
{
    public event EventHandler OnDoorClosed;
    Quaternion startRotation;
    Quaternion targetRotation;
    Quaternion rotToBePerformed;
    float smooth = 0.0f;

    void Start()
    {
        startRotation = transform.rotation;
        rotToBePerformed = Quaternion.Euler(-26, 0, 0);
        targetRotation = transform.rotation * rotToBePerformed;
    }

    private void OnMouseDown()
    {
        OnDoorClosed?.Invoke(this, EventArgs.Empty);
        while (smooth <= 1)
        {
            transform.rotation = Quaternion.Slerp(startRotation, targetRotation, smooth);
            smooth += 0.1f;
        }
    }

}    
