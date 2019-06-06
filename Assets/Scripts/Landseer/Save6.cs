using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save6 : MonoBehaviour
{
    public InputField usernameInput;
    public bool alreadyName6;

    void Start()
    {
        if (alreadyName6 = true)
        {
            usernameInput.text = PlayerPrefs.GetString("saveNom12");
        }
        if (alreadyName6 = false)
        {
            usernameInput.text = PlayerPrefs.GetString("saveNom13");
        }
    }

    public void SaveUsername(string newName)
    {
        alreadyName6 = true;
        PlayerPrefs.SetString("saveNom12", newName);
    }
    public void DeleteUsername(string newName1)
    {
        alreadyName6 = false;
        PlayerPrefs.SetString("saveNom13", newName1);
    }

}
