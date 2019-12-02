using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRpointer : MonoBehaviour
{
    public Transform PointerSP;

    public bool ShowPointerLine;

    public float PointerDistance = 100.00f;

    public int layermask = 1 << 8;

    public Color PointerColor; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        layermask = ~layermask;

        RaycastHit hit;

        if (Physics.Raycast(PointerSP.transform.position, PointerSP.transform.forward, out hit, PointerDistance, layermask))
        {
            Debug.DrawRay(PointerSP.transform.position, PointerSP.transform.forward * hit.distance, PointerColor, Time.deltaTime, false);
        }
    }
}
