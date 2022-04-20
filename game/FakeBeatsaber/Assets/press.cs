using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class press : MonoBehaviour
{
    // Start is called before the first frame update

    private SpriteRenderer theSR;
    public Sprite Img;
    public Sprite ImgPress;

    DancePadControls controls;

    public KeyCode buttonPress;

    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(buttonPress))
        {
            theSR.sprite = ImgPress;
        }

        if (Input.GetKeyUp(buttonPress))
        {
            theSR.sprite = Img;
        }
        if (Input.GetKeyDown("joystick button 13"))
        {
            Debug.Log("Dance pad key was pressed");
        }
    }
}
