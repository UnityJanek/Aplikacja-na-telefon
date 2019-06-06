using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save5 : MonoBehaviour
{
    public InputField usernameInput;
    public bool alreadyName5;

    void Start()
    {
        if (alreadyName5 = true)
        {
            usernameInput.text = PlayerPrefs.GetString("saveNom10");
        }
        if (alreadyName5 = false)
        {
            usernameInput.text = PlayerPrefs.GetString("saveNom11");
        }
    }

    public void SaveUsername(string newName)
    {
        alreadyName5 = true;
        PlayerPrefs.SetString("saveNom10", newName);
    }
    public void DeleteUsername(string newName1)
    {
        alreadyName5 = false;
        PlayerPrefs.SetString("saveNom11", newName1);
    }

}
