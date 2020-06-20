using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioSpawner : MonoBehaviour
{
    public GameObject mario;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawner()
    {
        GameObject test = (GameObject)Instantiate(mario, new Vector3(Random.Range(0, 10), Random.Range(0, 10), 0), Quaternion.identity);
        test.GetComponent<mario_handler>().isClone = true;
    }
}
