using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save2 : MonoBehaviour
{
    public InputField usernameInput;
    public bool alreadyName2;

    void Start()
    {
        if (alreadyName2 = true)
        {
            usernameInput.text = PlayerPrefs.GetString("saveNom4");
        }
        if (alreadyName2 = false)
        {
            usernameInput.text = PlayerPrefs.GetString("saveNom5");
        }
    }

    public void SaveUsername(string newName)
    {
        alreadyName2 = true;
        PlayerPrefs.SetString("saveNom4", newName);
    }
    public void DeleteUsername(string newName1)
    {
        alreadyName2 = false;
        PlayerPrefs.SetString("saveNom5", newName1);
    }

}
