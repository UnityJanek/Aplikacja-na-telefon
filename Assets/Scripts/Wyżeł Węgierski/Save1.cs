using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save1 : MonoBehaviour
{
    public InputField usernameInput;
    public bool alreadyName1;

    void Start()
    {
        if (alreadyName1 = true)
        {
            usernameInput.text = PlayerPrefs.GetString("saveNom1");
        }
        if (alreadyName1 = false)
        {
            usernameInput.text = PlayerPrefs.GetString("saveNom3");
        }
    }

    public void SaveUsername(string newName)
    {
        alreadyName1 = true;
        PlayerPrefs.SetString("saveNom1", newName);
    }
    public void DeleteUsername(string newName1)
    {
        alreadyName1 = false;
        PlayerPrefs.SetString("saveNom3", newName1);
    }

}
