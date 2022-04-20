using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialSpawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;
    public float beat = (60 / 126.4f) * 2;
    private float timer;
    public Arrow_Mover beatScroller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (beatScroller.hasStarted)
        {
            if (timer > beat && GameManager.instance.music.isPlaying)
            {
                GameObject cube = Instantiate(cubes[Random.Range(0, 2)], points[Random.Range(0, 4)]);
                cube.transform.localPosition = Vector3.zero;
                cube.transform.Rotate(transform.right, 90 * Random.Range(0, 4));
                timer -= beat;
                Destroy(cube.gameObject, 15f);
            }

            timer += Time.deltaTime;

        }
    }
}
