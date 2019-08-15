using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalPosMover : MonoBehaviour
{
    [SerializeField] Vector3 MoveMag;
    [SerializeField] float MoveTime;
    float TimeOffset;
    void Start()
    {
        TimeOffset = Random.Range(0, MoveTime);
    }
    void Update()
    {
        transform.localPosition += Mathf.Sin(MoveTime + Time.time / MoveTime) * MoveMag;
    }
}