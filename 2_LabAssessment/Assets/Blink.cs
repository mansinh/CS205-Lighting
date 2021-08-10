using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    [SerializeField] Material material;
    [SerializeField] Texture openEyes;
    [SerializeField] Texture closedEyes;
    [SerializeField] float duration;
    [SerializeField] float period;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BlinkTrigger());
    }
    IEnumerator BlinkTrigger()
    {
        while (true) {
            
            yield return new WaitForSeconds(period);
            StartCoroutine(BlinkAnim());
        }
    }
    IEnumerator BlinkAnim() {
        material.SetTexture("_BaseMap",closedEyes);
        yield return new WaitForSeconds(duration);
        material.SetTexture("_BaseMap", openEyes);
        yield return new WaitForSeconds(duration);
        material.SetTexture("_BaseMap", closedEyes);
        yield return new WaitForSeconds(duration);
        material.SetTexture("_BaseMap", openEyes);
    }
   
}
