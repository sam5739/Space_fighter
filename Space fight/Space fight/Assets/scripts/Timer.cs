using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timer;
    float seconds, minutes, hours;
    bool start;
    public Text stopWatch;
    Movement move;
    public Text timeTaken;
    // Start is called before the first frame update
    void Start()
    {
        move = GameObject.Find("SF_Free-Fighter").GetComponent<Movement>();
        start = false;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        StartStopWatch();
        if (move.health == 0)
            showDuration();
    }

    void StartStopWatch()
    {
        if (start)
        {
            timer += Time.deltaTime;
            seconds = (int)(timer % 60);
            minutes = (int)((timer / 60) % 60);
            hours = (int)(timer / 3600);

            stopWatch.text = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
        }        
    }

    public void startTime()
    {
        start = true;
    }

    public void showDuration()
    {
        timeTaken.text= "Total Time Taken:: " + hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}
