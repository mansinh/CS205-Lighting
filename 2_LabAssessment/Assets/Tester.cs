using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    Vector3 direction = Vector3.zero;
    float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
     
    // Update is called once per frame
    void Update()
    {
        direction = Vector3.zero;
        if (Input.GetKey(KeyCode.DownArrow)) { direction.y--; }
        if (Input.GetKey(KeyCode.UpArrow)) { direction.y++; }
        if (Input.GetKey(KeyCode.A)) { direction.x++; }
        if (Input.GetKey(KeyCode.D)) { direction.x--; }
        if (Input.GetKey(KeyCode.E)) { direction.z++; }
        if (Input.GetKey(KeyCode.Q)) { direction.z--; }
        
        transform.position += direction * speed * Time.deltaTime;
    }
}
