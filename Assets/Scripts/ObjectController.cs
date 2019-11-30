using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public float Weight;

    public Rigidbody RB;

    // Start is called before the first frame update
    void Start()
    {
        RB.mass = MassConvert(Weight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float MassConvert(float Pounds)
    {
        float GravitationalConstant = 9.80665f;

        float Newtons = Pounds * 4.44822f;

        float Mass = Newtons / GravitationalConstant;

        return Mass;
    }
}
