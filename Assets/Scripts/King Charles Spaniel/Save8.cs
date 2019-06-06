using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save8 : MonoBehaviour
{
    public InputField usernameInput;
    public bool alreadyName8;

    void Start()
    {
        if (alreadyName8 = true)
        {
            usernameInput.text = PlayerPrefs.GetString("saveNom16");
        }
        if (alreadyName8 = false)
        {
            usernameInput.text = PlayerPrefs.GetString("saveNom17");
        }
    }

    public void SaveUsername(string newName)
    {
        alreadyName8 = true;
        PlayerPrefs.SetString("saveNom16", newName);
    }
    public void DeleteUsername(string newName1)
    {
        alreadyName8 = false;
        PlayerPrefs.SetString("saveNom17", newName1);
    }

}
