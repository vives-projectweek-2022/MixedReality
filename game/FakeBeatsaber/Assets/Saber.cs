using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour

{
    public LayerMask layer;
    private Vector3 PreviousPos;
    public Slicer slicer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1f, layer))
        {
            if (Vector3.Angle(transform.position - PreviousPos, hit.transform.up) > 130)
            {
                GameManager.instance.NoteHit();
                //Destroy(hit.transform.gameObject);
                slicer.isTouched = true;
            }
        }
        PreviousPos = transform.position;
        
    }
}
