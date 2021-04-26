using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public void ChangeLevel1()
    {
        SceneManager.LoadScene(1);
    }
    public void ChangeLevel2()
    {
        SceneManager.LoadScene(2);
    }
    public void ChangeLevel3()
    {
        SceneManager.LoadScene(3);
    }
    public void ChangeLevel4()
    {
        SceneManager.LoadScene(4);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
