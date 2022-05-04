using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void frommenutolevels()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }
    public void returntomenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
        Time.timeScale = 1;
    }

    public void fromlevelstonormal()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }
    public void fromnormaltomenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Time.timeScale = 1;
    }

    public void fromlevelstoextra()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void fromextratomenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
        Time.timeScale = 1;
    }
    public void fromlevelstoonlybeat()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void fromonlybeattomenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
        Time.timeScale = 1;
    }

    public void fromlevelstoonlyddr()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void fromonlyddrtomenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
        Time.timeScale = 1;
    }

    public void frommenutocontorls()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void fromcontrolstomenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void frommenutoabout()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void fromabouttomenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

}