using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableScript : MonoBehaviour
{
    public GameObject camera;
    //public GameObject camera;
    //private bool state = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            camera.SetActive(!camera.activeSelf);
            Debug.Log("set");
        }
        //Debug.Log("Update is called");
    }
}
