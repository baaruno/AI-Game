using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyController : MonoBehaviour
{
    public string playGame;
    
    public void PlayGame()
    {
        SceneManager.LoadScene(playGame);
    }
}
