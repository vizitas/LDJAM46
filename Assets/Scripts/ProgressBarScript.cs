using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBarScript : MonoBehaviour
{

    public float MaxWidth;

    public float CurrentWidth;

    public float Progress = 0;

    public RectTransform RectTransform;

    public Bleeding Bleeding;

    // Update is called once per frame
    void Update()
    {
        if (Bleeding.healTime != -1)
        {
            RectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, MaxWidth / 100 * Bleeding.HealingProgress);
        } 
        else
        {
            RectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 0);
        }
    }
}
