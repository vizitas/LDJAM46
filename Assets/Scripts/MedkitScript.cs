using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{

    private int medkitCount = 4;

    public Text medkitText;

    public Bleeding bleeding;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        medkitText.text = "Medkits available: " + bleeding.Medkits;
    }
}
