using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCounter : MonoBehaviour
{
    public Text timerText;
    public float totalTime;
    int seconds;
    float hyouka;

    void Start()
    { 
    }

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

        totalTime -= Time.deltaTime;
        seconds = (int)totalTime;
        timerText.text = seconds.ToString();

        if (totalTime <= 0f)
        {
            hyouka = agebaidou.GetcurrentHP();
            //if (hyouka >= 400 & hyouka <= 800)
            //{
            //    SceneManager.LoadScene("A");
            //}
            //else if (hyouka >= 100 & hyouka <= 399)
            //{
            //    SceneManager.LoadScene("B");
            //}
            //else if (hyouka >= 801 & hyouka <= 900)
            //{
            //    SceneManager.LoadScene("B");
            //}
            //else
            //{
            //    SceneManager.LoadScene("C");
            //}
            SceneManager.LoadScene("End");
        }
    }
}

