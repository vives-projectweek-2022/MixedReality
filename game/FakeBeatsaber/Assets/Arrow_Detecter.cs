using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Detecter : MonoBehaviour
{

    public bool canBePressed;

    public KeyCode keyToPress;

    public GameObject hitEffect;
    public GameObject goodEffect;
    public GameObject perfectEffect;
    public GameObject missEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)
            {
                gameObject.SetActive(false);

                //GameManager.instance.NoteHit();

                if(Mathf.Abs(transform.position.x) > 0.25f)
                {
                    Debug.Log("Normal hit");
                    GameManager.instance.NormalHit();
                    Instantiate(hitEffect, transform.position, hitEffect.transform.rotation);
                }
                else if(Mathf.Abs(transform.position.x) > 0.05f)
                {
                    Debug.Log("Good hit");
                    GameManager.instance.GoodHit();
                    Instantiate(goodEffect, transform.position, goodEffect.transform.rotation);
                }
                else
                {
                    Debug.Log("Perfect hit");
                    GameManager.instance.PerfectHit();
                    Instantiate(perfectEffect, transform.position, perfectEffect.transform.rotation);

                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;

            GameManager.instance.NoteMissed();
            Instantiate(missEffect, missEffect.transform.position, missEffect.transform.rotation);

        }
    }
}
