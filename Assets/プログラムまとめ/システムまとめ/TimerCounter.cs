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


    // Start is called before the first frame update
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (Collider2D.gameObject.name = "揚げ具合")
    //    {
    //        SceneManager.LoadScene("C");
    //    }
    //    if (Collider2D.gameObject.name = "揚げ具合orange")
    //    {
    //        SceneManager.LoadScene("B");
    //    }
    //    if (Collider2D.gameObject.name = "揚げ具合green")
    //    {
    //        SceneManager.LoadScene("A");
    //    }
    //    if (Collider2D.gameObject.name = "揚げ具合red")
    //    {
    //        SceneManager.LoadScene("C");
    //    }
    //}
    // Update is called once per frame
    void Update()
    {

        totalTime -= Time.deltaTime;
        seconds = (int)totalTime;
        timerText.text = seconds.ToString();
        if (totalTime <= 0f)
        {
            SceneManager.LoadScene("End");
        }
    }
}

