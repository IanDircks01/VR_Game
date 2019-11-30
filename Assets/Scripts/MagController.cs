using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagController : MonoBehaviour
{
    public bool IsLoaded;

    public GameObject Bullet;

    // Start is called before the first frame update
    void Start()
    {
        if (IsLoaded == false)
        {
            Destroy(Bullet);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
