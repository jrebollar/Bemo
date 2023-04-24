using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float curTime;
    private bool isTimerRunning;

    public TMP_Text textObject;
    public float startTimeSeconds;

    [SerializeField] GameObject secretEnding;

     [SerializeField] Camera cam;
    private void Start()
    {
        curTime = startTimeSeconds;
        isTimerRunning = true;
    }

    private void Update()
    {
        if(isTimerRunning)
        {
            if (curTime > 0)
            {
                // Update the timer and display it
                curTime -= Time.deltaTime;
                DisplayTime();
            }
            else
            {
                // Keep timer at 0, and stop it
                curTime = 0;
                isTimerRunning = false;
            }
        }
    }

    // Display time left on UI
    private void DisplayTime()
    {
        // Only display time left based on curTime if it is above or equal to zero
        if(curTime >= 0)
        {
            // Caculate and format time to display it
            int minutes = Mathf.FloorToInt(curTime / 60);
            int seconds = Mathf.FloorToInt(curTime % 60);
            textObject.text = string.Format("{0}:{1:00}", minutes, seconds);
        }
        else
        {
            textObject.text = "0:00";
            DestroyOptions();
            ActivateSecretEnding();
        }
    }
    public bool timeRunning()
    {
        return isTimerRunning;
    }
    public float GetCurrentTime()
    {
        return curTime;
    }
    private void DestroyOptions()
    {
        GameObject obj = GameObject.Find("Options");
        Destroy(obj);
    }

    private void ActivateSecretEnding(){
        secretEnding.SetActive(true);

        RenderSettings.fog = true;
        RenderSettings.fogColor = Color.red;
        RenderSettings.fogDensity = 0.1f;

        cam.backgroundColor = Color.black;
    }
}

