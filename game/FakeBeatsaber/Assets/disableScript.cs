using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class disableScript : MonoBehaviour
{
    //public GameObject camera;
    public GameObject pauseMenu;
    //bool buttonValue;
    public bool wasDown = false;
    public bool isDown = false;
    InputDevice device;
    public XRController controller = null;
    bool paused = false;
    //public GameObject camera;
    //private bool state = true;
    // Start is called before the first frame update
    void Start()
    {
        device = InputDevices.GetDeviceAtXRNode(controller.controllerNode);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    camera.SetActive(!camera.activeSelf);
        //    //Debug.Log("set");
        //}
        wasDown = isDown;
        device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.gripButton, out isDown);
        if(ButtonDown())
        {
            if(paused)
            {
                ResumeGame();
                GameManager.instance.paused = false;
                GameManager.instance.music.UnPause();
                paused = !paused;
            }
            else
            {
                PauseGame();
                GameManager.instance.paused = true;
                GameManager.instance.music.Pause();
                paused = !paused;

            }
            pauseMenu.SetActive(!pauseMenu.activeSelf);
            Debug.Log("pressed button");
        }

        //Debug.Log("Update is called");
    }

    public bool ButtonDown()
    {
        return isDown && !wasDown;
    }
    public bool Button()
    {
        return isDown;
    }
    public bool ButtonUp()
    {
        return wasDown && !isDown;
    }

    void PauseGame()
    {
        Time.timeScale = 0;
    }
    void ResumeGame()
    {
        Time.timeScale = 1;
    }

}
