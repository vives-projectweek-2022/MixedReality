using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraVR : MonoBehaviour
{
    static WebCamTexture backCam;

    private void Start()
    {
        if (backCam == null)
        {
            backCam = new WebCamTexture();
        }

        GetComponent<Renderer>().material.mainTexture = backCam;

        if (!backCam.isPlaying)
        {
            backCam.Play();
        }
            
    }

    private void Update()
    {
        
    }
}