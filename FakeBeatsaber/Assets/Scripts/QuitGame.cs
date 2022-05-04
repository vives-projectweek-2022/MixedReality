using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void QuitMe()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
