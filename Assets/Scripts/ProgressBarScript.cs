using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarScript : MonoBehaviour
{
    public Bleeding Bleeding;

    public Slider Slider;

    // Update is called once per frame
    void Update()
    {
        if (Bleeding.healing)
        {
            Slider.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            Slider.value = Bleeding.HealingProgress / 100;
        } 
        else
        {
            Slider.GetComponent<RectTransform>().localScale = new Vector3(0, 0, 0);
            Slider.value = 0;
        }
    }
}
