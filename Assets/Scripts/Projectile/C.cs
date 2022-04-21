using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C : MonoBehaviour
{
    public A a;
    public B b;

    public float float_val;

    void Update()
    {
        float_val = a.float_val + b.float_val;
    }
}
