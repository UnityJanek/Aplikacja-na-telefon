﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input3 : MonoBehaviour
{

    public InputField inputField;
    public GameObject image;

    void Start()
    {
        image.SetActive(false);
    }

    public void text()
    {
        if (inputField.text == "Nova Scotia Duck Tolling Retriever")
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