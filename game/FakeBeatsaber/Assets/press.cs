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

    void Awake()
    {
        controls = new DancePadControls();

        controls.Gameplay.Left.performed += ctx => Press();
    }

    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    void Press()
    {
        theSR.sprite = ImgPress;
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
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }
}
