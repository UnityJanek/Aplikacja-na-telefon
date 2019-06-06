using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    public InputField usernameInput;
    public bool alreadyName;

    void Start()
    {
        if (alreadyName = true)
        {
            usernameInput.text = PlayerPrefs.GetString("saveNom");
        }
        if (alreadyName = false)
        {
            usernameInput.text = PlayerPrefs.GetString("saveNom2");
        }
    }

    public void SaveUsername(string newName)
    {
        alreadyName = true;
        PlayerPrefs.SetString("saveNom", newName);
    }

    public void DeleteUsername(string newName1)
    {
        alreadyName = false;
        PlayerPrefs.SetString("saveNom2", newName1);
    }

}
