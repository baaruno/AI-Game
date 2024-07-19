using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public GameObject gameOverMenu;
    public string backToLobby;

    public void RestartGame()
    {
        gameOverMenu.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        //SceneManager.LoadScene(restartGame);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void BackToLobby()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(backToLobby);
    }
}
