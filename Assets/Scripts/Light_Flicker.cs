using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Flicker : MonoBehaviour
{
    public float flickerIntensity = 0.2f;
    public float flickerPerSec = 3.0f;
    public float speedRandomness = 1.0f;

    private float time;
    private float startIntensity;
    private Light light;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        startIntensity = light.intensity;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * (1 - Random.Range(-speedRandomness, speedRandomness)) * Mathf.PI;
        light.intensity = startIntensity + Mathf.Sin(time * flickerPerSec) * flickerIntensity;
    }
}
