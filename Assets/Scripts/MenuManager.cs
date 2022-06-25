using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    public PlayerMove playerMove;
    public GameObject[] menuButton;
    public GameObject pauseButton;

    private void Awake()
    {
        
    }

    private void Start()
    {
        pauseButton.SetActive(false);
        
    }

    public void Play()
    {
        playerMove.shouldPlay = true;
        pauseButton.SetActive(true);
        foreach (var item in menuButton)
        {
            item.SetActive(false);
        }
    }

    public void Pause()
    {
        playerMove.shouldPlay = false;

        pauseButton.SetActive(false);
        foreach (var item in menuButton)
        {
            item.SetActive(true);
        }
    }

    public void Levels(int levelNumber)
    {

        SceneManager.LoadScene(levelNumber);
    }
}
