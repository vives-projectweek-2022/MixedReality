using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    private int popUpIndex = 0;
    public GameObject spawner;

    float timer = 0;
    bool timerReached = false;
    bool keyPressed = false;

    private void Update()
    {
        for (int i = 0; i < popUps.Length; i++)
        {
            if (i == popUpIndex)
            {
                popUps[popUpIndex].SetActive(true);
                //Debug.Log("Object" + i + "=active");
                //Debug.Log(popUps[popUpIndex]);
            }
            else if (i != popUpIndex)
            {
                popUps[popUpIndex].SetActive(false);
                //Debug.Log("Object" + i + "=inactive");
                //Debug.Log(popUps[popUpIndex].activeInHierarchy);
            }
        }

        if(popUpIndex == 0)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                GameManager.instance.beatScroller.hasStarted = true;
                keyPressed = true;
                //yield return new WaitForSeconds(2);
                //GameManager.instance.beatScroller.hasStarted = false;
            }
            if (!timerReached && keyPressed)
            {
                timer += Time.deltaTime;
                Debug.Log("timer up");

            }


            if (!timerReached && timer > 3)
            {
                Debug.Log("Done waiting");
                popUpIndex++;

                //Set to false so that We don't run this again
                timerReached = true;
            }
        }
        else if (popUpIndex == 1)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Debug.Log("second object should go away");
                GameManager.instance.startCubeSpawner = true;
                //popUpIndex++;
            }
        }
        //Debug.Log(popUpIndex);
    }
}
