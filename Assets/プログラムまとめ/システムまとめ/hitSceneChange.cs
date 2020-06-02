using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class hitSceneChange : MonoBehaviour
{
        void OnTriggerEnter2D(Collider2D collision)
        {
        SceneManager.LoadScene("Game");
        }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
