using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save4 : MonoBehaviour
{
    public InputField usernameInput;
    public bool alreadyName4;

    void Start()
    {
        if (alreadyName4 = true)
        {
            usernameInput.text = PlayerPrefs.GetString("saveNom8");
        }
        if (alreadyName4 = false)
        {
            usernameInput.text = PlayerPrefs.GetString("saveNom9");
        }
    }

    public void SaveUsername(string newName)
    {
        alreadyName4 = true;
        PlayerPrefs.SetString("saveNom8", newName);
    }
    public void DeleteUsername(string newName1)
    {
        alreadyName4 = false;
        PlayerPrefs.SetString("saveNom9", newName1);
    }

}
