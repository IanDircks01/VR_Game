using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagManager : MonoBehaviour
{
    public GameObject CurrentMag;

    public Transform MagSetPoint;

    public bool HasMag = true;

    public void SetMag(GameObject Mag)
    {
        if (CurrentMag != null)
        {
            ReleaseCurrentMag();
        }

        CurrentMag = Mag;
        Mag.transform.parent = MagSetPoint;
        Mag.transform.position = MagSetPoint.position;
    }

    public void ReleaseCurrentMag()
    {
        if (HasMag == true)
        {
            return;
        }

        CurrentMag.GetComponent<MagController>().Unload();
        CurrentMag.transform.parent = null;
        CurrentMag = null;
        HasMag = false;
    }
}
