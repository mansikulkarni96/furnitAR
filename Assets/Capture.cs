using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capture : MonoBehaviour {

    void OnMouseDown()
    {
        Application.CaptureScreenshot("Screenshot.png");
    }
}
