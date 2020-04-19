using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaderScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (GameStateSingleton.Instance.GameState != GameStateSingleton.GameStates.DEATH)
        {
            GetComponent<RectTransform>().localScale = new Vector3(0, 0, 0);
        }
        else
        {
            GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            GetComponent<CanvasRenderer>().SetAlpha((Time.time - GameStateSingleton.Instance.DeathTime) / 2);
        }
    }
}
