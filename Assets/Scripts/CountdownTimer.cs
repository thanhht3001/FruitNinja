using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] float currentTime = 0f;
    [SerializeField] float startingTime = 0f;
 
    [SerializeField] Text countdownTimer;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        if (currentTime >= 0) {
            countdownTimer.text = currentTime.ToString();
        }
        else
        {

        }
        
    }
}
