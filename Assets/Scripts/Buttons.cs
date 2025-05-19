using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject MainMenu;
    public GameObject GameOverMenu;
    public GameObject LevelCompleteMenu;

    void Start()
    {
    }

    public void Pause()
    {
        PauseMenu.SetActive(true);
    }
    public void Play()
    {
        PauseMenu.SetActive(false);
        MainMenu.SetActive(false);
        GameOverMenu.SetActive(false);
        LevelCompleteMenu.SetActive(false);
    }
    public void Replay()
    {
    }
    public void Levels()
    {
    }
}
