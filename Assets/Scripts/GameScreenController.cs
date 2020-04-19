using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameScreenController : MonoBehaviour
{
    public GameObject canvas;

    // Update is called once per frame
    void Update()
    {
        switch (GameStateSingleton.Instance.GameState)
        {
            case GameStateSingleton.GameStates.MENU:

                break;
            case GameStateSingleton.GameStates.PLAYING:

                break;
            case GameStateSingleton.GameStates.DEATH:


                break;
            default:
                break;
        }
    }
}
