using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public GameObject startPage, gamePage;
  
    enum PageState
    {
        None,
        Start,
        Game
    }

    private void Awake()
    {
        startPage.SetActive(true);
        gamePage.SetActive(false);
    }
    public void SetGamePage()
    {
        startPage.SetActive(false);
        gamePage.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }


}
