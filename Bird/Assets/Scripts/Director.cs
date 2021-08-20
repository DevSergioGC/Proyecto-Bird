using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Director : MonoBehaviour
{
    public GameObject gameoverCanvas;
    public string sceneName;
    public string goToMenu;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    public void Gameover()
    {
        gameoverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay() 
    {
       SceneManager.LoadScene(sceneName);
    }

    public void Menu() 
    {
       SceneManager.LoadScene(goToMenu);
    }

    
}
