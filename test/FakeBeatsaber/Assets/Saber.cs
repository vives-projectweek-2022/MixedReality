using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour

{
    public LayerMask layer;
    private Vector3 PreviousPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.right, out hit, 1, layer))
        {
            if (Vector3.Angle(transform.position - PreviousPos, hit.transform.up) > 90)
            {
                Destroy(hit.transform.gameObject);
            }
        }
        PreviousPos = transform.position;
        
    }
}
