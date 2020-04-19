using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateSingleton : Singleton<GameStateSingleton>
{
    public enum GameStates
    {
        MENU,
        PLAYING,
        DEATH
    }

    public GameStates GameState = GameStates.MENU;

    public void ChangeGameState(GameStates state)
    {
        GameState = state;
    }

    public void Death()
    {
        Debug.Log("DEATH");
        GameState = GameStates.DEATH;
        Invoke("Restart", 3);
    }

    public void StartGame()
    {
        GameState = GameStates.PLAYING;
        SceneManager.UnloadSceneAsync("Menu");
        SceneManager.LoadScene("SampleScene");
    }

    public void Menu()
    {
        GameState = GameStates.MENU;
    }

    public void Restart()
    {
        SceneManager.UnloadSceneAsync("DeathScreen");
        SceneManager.LoadScene("SampleScene");
    }
}
