using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] GameObject flashLight;
    [SerializeField] AudioClip click;
    [SerializeField] AudioSource source;

    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (flashLight.activeSelf)
            {
                flashLight.gameObject.SetActive(false);
                source.PlayOneShot(click);
            }
            else if (!flashLight.activeSelf)
            {
                flashLight.gameObject.SetActive(true);
                source.PlayOneShot(click);
            }
        }
    }
}
