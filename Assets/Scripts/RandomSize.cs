using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class RandomSize : MonoBehaviour
{
    [DllImport("RandomScaleValue.dll")]
    static extern float RandomScaleValue(float min, float max);

    public float minValue, maxValue;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector2(transform.localScale.x * RandomScaleValue(minValue, maxValue), transform.localScale.y * RandomScaleValue(minValue, maxValue));
    }
}