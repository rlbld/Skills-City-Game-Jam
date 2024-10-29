using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;

    // Update is called once per frame
    void Update()
    {

        if (remainingTime > 10)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime > 0 && remainingTime < 10)
        {
            remainingTime -= Time.deltaTime;
            timerText.color = Color.red;
        }
        else if (remainingTime <= 0)
        {
            remainingTime = 0;
            // GameOver();
        }
        
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("battery")) 
        {
            remainingTime += 60;
        }
    }
}
