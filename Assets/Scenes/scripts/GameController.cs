using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
     public GameObject GameOverPanel;
     public GameObject tapToStart;
     public GameObject scoreText;
    public void Start()
    {
        GameOverPanel.SetActive(false);
        tapToStart.SetActive(true);
        scoreText.SetActive(false);
        PauseGame();
    }
    public void Update()
    {
         if (Input.GetKeyDown(KeyCode.Mouse0))
        {     StartGame();
        }
    }
    public void GameOver()
{
    GameOverPanel.SetActive(true);
     scoreText.SetActive(false);
}
    public void Restart()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("");
    }
    public void Quit()
    {
     Application.Quit();   
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        tapToStart.SetActive(false);
         scoreText.SetActive(true);
        Time.timeScale = 1f;
    }
}