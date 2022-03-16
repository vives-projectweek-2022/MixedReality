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

    private int currentMultiplier = 1;
    private int multiplierTracker = 0;
    private int[] multiplierThresholds = { 2, 4, 6, 8, 10, 14, 18, 22, 26, 30, 36, 42, 48, 58, 68, 78, 90, 102, 122, 162 };


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
