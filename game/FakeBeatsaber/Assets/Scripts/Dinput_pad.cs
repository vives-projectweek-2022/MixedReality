using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinput_pad : MonoBehaviour
{
    public string[] axes;
    public string[] buttons;
    // Start is called before the first frame update
    void Start()
    {
        axes = new string[28];
        buttons = new string[20];
    }

    // Update is called once per frame
    void Update()
    {
        ShowAxes();
        ShowButtons();
    }

    void ShowAxes()
    {
        for (int i=0; i < axes.Length; i++)
        {
            string axisName = "Axis " + (i > 1 ? (i + 1).ToString() : i < 1 ? "X" : "Y");
            axes[i] = axisName + " = " + Input.GetAxis(axisName.ToString());
        }
    }

    void ShowButtons()
    {
        for (int i = 0; i< buttons.Length; i++)
        {
            buttons[i] = "joystick button " + (i).ToString() + (Input.GetKey("joystick button " + i.ToString()) ? " is used" : "");
        }
    }
}
