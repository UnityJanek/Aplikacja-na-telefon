using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input : MonoBehaviour {

    public InputField inputField;
    public GameObject image;

	void Start ()
    {
        image.SetActive(false);
	}

    public void text()
    {
        if (inputField.text == "Owczarek Podhalański")
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
