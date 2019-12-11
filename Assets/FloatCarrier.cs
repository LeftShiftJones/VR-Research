using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatCarrier : MonoBehaviour
{
    public float val;
    // Start is called before the first frame update
    void Start()
    {
        val = 0;
    }

    void setVal(float newVal) {
        val = newVal;
    }

    float getVal() {
        return val;
    }
}
