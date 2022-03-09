using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class press : MonoBehaviour
{
    // Start is called before the first frame update

    private SpriteRenderer theSR;
    public Sprite Img;
    public Sprite ImgPress;

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
    }
}
