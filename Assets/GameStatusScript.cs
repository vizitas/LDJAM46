using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStatusScript : MonoBehaviour
{

    public Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = GameStateSingleton.Instance.GameState.ToString();
    }
}
