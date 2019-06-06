using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save7 : MonoBehaviour
{
    public InputField usernameInput;
    public bool alreadyName7;

    void Start()
    {
        if (alreadyName7 = true)
        {
            usernameInput.text = PlayerPrefs.GetString("saveNom14");
        }
        if (alreadyName7 = false)
        {
            usernameInput.text = PlayerPrefs.GetString("saveNom15");
        }
    }

    public void SaveUsername(string newName)
    {
        alreadyName7 = true;
        PlayerPrefs.SetString("saveNom14", newName);
    }
    public void DeleteUsername(string newName1)
    {
        alreadyName7 = false;
        PlayerPrefs.SetString("saveNom15", newName1);
    }

}
