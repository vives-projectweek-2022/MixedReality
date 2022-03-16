using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public AudioSource music;
    public bool playing;

    public Arrow_Mover beatScroller;

    public static GameManager instance;

    public int currentScore;
    public int scorePerNote = 100;

    public TextMesh scoreText;
    public TextMesh multiplierText;

    public int currentMultiplier = 1;
    public int multiplierTracker;
    public int[] multiplierThresholds = { 4, 8, 16 };

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (!playing)
        {
            if(Input.anyKeyDown)
            {
                playing = true;
                beatScroller.hasStarted = true;

                music.Play();
            }
        }
    }

    public void NoteHit()
    {
        Debug.Log("Hit on Time");

        if(currentMultiplier-1 < multiplierThresholds.Length)
        {
            multiplierTracker++;

            if (multiplierThresholds[currentMultiplier - 1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultiplier++;
            }

            multiplierText.text = "multiplier: x" + currentMultiplier;

            currentScore += scorePerNote * currentMultiplier;
            scoreText.text = "Score: " + currentScore;
        }
    }

    public void NoteMissed()
    {
        Debug.Log("Missed Note");

        currentMultiplier = 1;
        multiplierTracker = 0;

        multiplierText.text = "multiplier: x" + currentMultiplier;

    }
}
