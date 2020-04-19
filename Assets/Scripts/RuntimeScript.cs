using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuntimeScript : MonoBehaviour
{
    public Text RuntimeText;

    // Update is called once per frame
    void Update()
    {
        RuntimeText.text = Time.time.ToString();
    }
}
