﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPLAY: MonoBehaviour {

    public void ChangeToScene(string sceneToChangeTo)
    {
        Application.LoadLevel(sceneToChangeTo);
    }
}
