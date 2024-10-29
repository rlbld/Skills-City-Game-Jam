using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] GameObject flashLight;
    
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            flashLight.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            flashLight.SetActive(false);
        }
    }
}
