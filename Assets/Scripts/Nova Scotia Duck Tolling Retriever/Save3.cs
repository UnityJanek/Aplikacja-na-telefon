using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save3 : MonoBehaviour
{
    public InputField usernameInput;
    public bool alreadyName3;

    void Start()
    {
        if (alreadyName3 = true)
        {
            usernameInput.text = PlayerPrefs.GetString("saveNom6");
        }
        if (alreadyName3 = false)
        {
            usernameInput.text = PlayerPrefs.GetString("saveNom7");
        }
    }

    public void SaveUsername(string newName)
    {
        alreadyName3 = true;
        PlayerPrefs.SetString("saveNom6", newName);
    }
    public void DeleteUsername(string newName1)
    {
        alreadyName3 = false;
        PlayerPrefs.SetString("saveNom7", newName1);
    }

}
