using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    [SerializeField] Light flickeringLight;
    
    [SerializeField] float flicker = 1;
    [SerializeField] Material material;

    float intensity;
    Color emission;
    // Start is called before the first frame update
    void Start()
    {
       emission = material.GetColor("_EmissionColor");
        
        intensity = flickeringLight.intensity;
    }

    // Update is called once per frame
    void Update()
    {
        float deltaIntensity = Random.value * flicker;
        flickeringLight.intensity = intensity + deltaIntensity;
        material.SetColor("_EmissionColor", emission * (1 + deltaIntensity));
        
        //material.SetFloat("emission", emission + Random.value * flicker);
    }
}
