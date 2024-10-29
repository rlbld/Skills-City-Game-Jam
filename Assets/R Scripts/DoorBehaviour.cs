using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoorBehaviour : MonoBehaviour
{
    public event EventHandler OnDoorClosed;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnDoorClosed?.Invoke(this, EventArgs.Empty);
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Mouse Click Detected");
    }
}    
