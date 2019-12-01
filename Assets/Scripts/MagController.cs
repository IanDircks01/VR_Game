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

    public void Unload()
    {
        if (IsLoaded == true)
        {
            Destroy(Bullet);
            IsLoaded = false;
        }
        else
        {
            Debug.LogWarning("Gun is already unloaded");
        }
    }
}
