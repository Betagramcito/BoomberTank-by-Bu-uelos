using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo : MonoBehaviour
{
   
public class Timer : MonoBehaviour
{
    public Text timerText; 
    private float timeRemaining = 180f; 
    private bool isRunning = true;

    void Update()
    {
        if (isRunning)
        {
            if (timeRemaining > 0)
            {
               
                timeRemaining -= Time.deltaTime;
                int minutes = Mathf.FloorToInt(timeRemaining / 60);
                int seconds = Mathf.FloorToInt(timeRemaining % 60);
                timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); 
            }
            else
            {
                
                timeRemaining = 0;
                isRunning = false;
                timerText.text = "00:00";
                TimerEnded(); 
            }
        }
    }

    private void TimerEnded()
    {
       
        Debug.Log("¡Tiempo agotado!");
       
    }
}

   
}
