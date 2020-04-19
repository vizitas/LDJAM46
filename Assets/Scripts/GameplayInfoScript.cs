using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayInfoScript : MonoBehaviour
{
    public Text Text;

    public Bleeding Bleeding;

    // Update is called once per frame
    void Update()
    {
        if (Bleeding.HealingProgress == 0 && Bleeding.bleeding)
        {
            Text.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        }
        else
        {
            Text.GetComponent<RectTransform>().localScale = new Vector3(0, 0, 0);
        }
    }
}
