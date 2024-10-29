using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class DoorCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingDoors;

    // Start is called before the first frame update
    void Start()
    {
        DoorBehaviour doorBehaviour = GetComponent<DoorBehaviour>();
        doorBehaviour.OnDoorClosed += DoorCountdown;
    }

    private void DoorCountdown(object sender, EventArgs e)
    {
        remainingDoors--;
        DoorBehaviour doorBehaviour = GetComponent<DoorBehaviour>();
        doorBehaviour.OnDoorClosed -= DoorCountdown;
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = string.Format("Open doors - {0}", remainingDoors);
    }

}
