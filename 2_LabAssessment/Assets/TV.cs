using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV : MonoBehaviour
{
    [SerializeField] Material screen;
    [SerializeField] Texture original, changed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.value < 0.005)
        {
            screen.SetTexture("_EmissionMap", changed);
        }
        else {
            screen.SetTexture("_EmissionMap", original);
        }
    }
}
