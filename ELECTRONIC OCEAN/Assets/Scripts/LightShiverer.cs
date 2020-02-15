using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightShiverer : MonoBehaviour
{
    [SerializeField] Light light;
    [SerializeField] float ShiverMagnitude, ShiverPeriod, ShiverOffset, lightIntensity;
    Vector3 pos, posDif, rotDif;
    Quaternion rot;
    void Start()
    {
        pos = transform.position;
        rot = transform.rotation;
        lightIntensity = light.intensity;
        ShiverPeriod = Random.Range(5, 20);
        ShiverOffset = Random.Range(30, 100);
    }

    void Update()
    {
        float t = ShiverOffset + Time.time / ShiverPeriod;
        posDif = ShiverMagnitude *
            new Vector3(Mathf.Sin(t), -Mathf.Sin(t), -Mathf.Sin(t));
        rotDif = ShiverMagnitude *
            new Vector3(-Mathf.Sin(t), -Mathf.Sin(t), Mathf.Sin(t));
        transform.position = pos + posDif;
        transform.rotation = rot * Quaternion.Euler(rotDif);
        light.intensity = lightIntensity + ShiverMagnitude * Mathf.Sin(t);
    }
}