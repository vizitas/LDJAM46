using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateSingleton : MonoBehaviour
{
    //#todo states
    private static GameStateSingleton instance;
    public static GameStateSingleton Instance
    {
        get{
            if (instance == null)
                instance = new GameStateSingleton();
            return instance;
        }
    }

            private GameStateSingleton()
    {

    }
    public void Death()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
