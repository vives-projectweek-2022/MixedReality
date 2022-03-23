using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void QuitMe()
    {
        Application.Quit();
        Debug.Log("Bye bye");
    }
}
