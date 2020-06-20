using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peach_handler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0);
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
