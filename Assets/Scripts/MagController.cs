using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagController : MonoBehaviour
{
    public bool IsLoaded;

    public GameObject Bullet;

    public Rigidbody RB;

    // Start is called before the first frame update
    void Start()
    {
        if (IsLoaded == false)
        {
            Destroy(Bullet);
        }
    }

    public void Load()
    {
        if (IsLoaded == false)
        {
            IsLoaded = true;
            RB.isKinematic = false;
            RB.useGravity = false;
        } else
        {
            Debug.LogWarning("Gun is already loaded");
        }
    }

    public void Unload()
    {
        if (IsLoaded == true)
        {
            Destroy(Bullet);
            IsLoaded = false;
            RB.isKinematic = false;
            RB.useGravity = true;
        }
        else
        {
            Debug.LogWarning("Gun is already unloaded");
        }
    }
}
