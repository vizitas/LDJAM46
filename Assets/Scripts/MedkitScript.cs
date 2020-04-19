using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MedkitScript : MonoBehaviour
{
    public Text medkitText;

    public Bleeding bleeding;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        medkitText.text = "Medkits available: " + bleeding.Medkits;
    }
}
