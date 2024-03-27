using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotsScrpt : MonoBehaviour
{
    void SetColor(Color c)
    {
        var colorHandler = GetComponentInChildren<ColorHandler>();
        if (colorHandler != null)
        {
            colorHandler.SetColor(c);
        }
    }
}
