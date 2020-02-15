using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] Vector3 Rot;
    [SerializeField] AnimationCurve RotRatio;
    [SerializeField] float RotLength;
    void Update()
    {
        transform.rotation *= Quaternion.Euler(Rot * RotRatio.Evaluate(Mathf.Repeat(Time.time / RotLength, 1)));;
    }
}