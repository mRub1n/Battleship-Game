using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : MonoBehaviour
{
    public A a;

    public float float_val;

    void Update()
    {
        if (a.float_val > 10)
        {
            float_val += 0.1f;
        }
    }

    void LateUpdate()
    {

    }
}
