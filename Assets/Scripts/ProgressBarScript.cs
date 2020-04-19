using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBarScript : MonoBehaviour
{

    public float MaxWidth;

    public float CurrentWidth;

    public float Progress = 0;

    public RectTransform RectTransform;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        }
    }
}
