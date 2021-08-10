using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep : MonoBehaviour
{
    [SerializeField] float freq = 2;
    [SerializeField] float amp = 0.01f;
    [SerializeField] Transform snot;
    [SerializeField] float snotSize;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(1,1+Mathf.Sin(Time.time*freq)*amp,1);
        snot.localScale = Vector3.one * Mathf.Pow(Mathf.Max((-Mathf.Sin(Time.time * freq)+0.5f)/1.5f, 0),1f/2) * snotSize;
    }
}
