using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input4 : MonoBehaviour
{

    public InputField inputField;
    public GameObject image;

    void Start()
    {
        image.SetActive(false);
    }

    public void text()
    {
        if (inputField.text == "Seter Szkocki")
        {
            Debug.Log("True");
            image.SetActive(true);
        }
        else
        {
            Debug.Log("False");
        }
    }
}
