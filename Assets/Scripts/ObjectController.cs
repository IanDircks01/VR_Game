using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public float Weight;

    public Rigidbody RB;

    public PhysicMaterial PM;

    public Collider[] colliders;

    // Start is called before the first frame update
    void Start()
    {
        RB.mass = MassConvert(Weight);

        if (PM != null)
        {
            colliders = GetComponentsInChildren<Collider>();
            foreach(Collider c in colliders){
                c.material = PM;
            }
        }
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
