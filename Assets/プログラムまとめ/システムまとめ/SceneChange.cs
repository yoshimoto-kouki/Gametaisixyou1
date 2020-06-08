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
    public void ButtonClicked設定()
    {
        SceneManager.LoadScene("設定");
    }
    public void ButtonClickedGame()
    {
        SceneManager.LoadScene("End");
    }
    public void ButtonClickedEnd()
    {
        SceneManager.LoadScene("Title");
    }
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android && Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void EndGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
		Application.OpenURL("http://www.yahoo.co.jp/");
#else
		Application.Quit();
#endif
    }

}
