﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input8 : MonoBehaviour
{

    public InputField inputField;
    public GameObject image;

    void Start()
    {
        image.SetActive(false);
    }

    public void text()
    {
        if (inputField.text == "King Charles Spaniel")
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