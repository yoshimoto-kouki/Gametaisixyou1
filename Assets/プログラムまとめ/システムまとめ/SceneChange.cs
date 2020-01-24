using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour
{
  

    public void ButtonClickedTitle()
    {
        SceneManager.LoadScene("Game");
    }
    public void ButtonClickedGame()
    {
        SceneManager.LoadScene("End");
    }
    public void ButtonClickedEnd()
    {
        SceneManager.LoadScene("Title");
    }


}
