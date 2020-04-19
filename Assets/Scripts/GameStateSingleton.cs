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

    public float DeathTime = -1f;

    public void ChangeGameState(GameStates state)
    {
        GameState = state;
    }

    public void Death()
    {
        Debug.Log("DEATH");
        GameState = GameStates.DEATH;
        DeathTime = Time.time;
        Invoke("LoadDeathScreen", 3);
    }

    private void LoadDeathScreen()
    {
        SceneManager.LoadScene("DeathScreen");
    }

    public void StartGame()
    {
        GameState = GameStates.PLAYING;
        SceneManager.LoadScene("SampleScene");
    }

    public void Menu()
    {
        GameState = GameStates.MENU;
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
