using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioSpawner : MonoBehaviour
{
    public GameObject mario;
    //  public GameObject bigMario;
    public int welle = 0;
    private int left_marios = 0;
    // Start is called before the first frame update
    void Start()
    {
        welle++;
        Spawner();
    }

    // Update is called once per frame
    void Update()
    {
        if (left_marios == 0)
        {
            welle++;
            for (int i = 0; i < welle; i++)
            {
                Spawner();
            }
        }
        Spawner();
    }

    void Spawner()
    {
        if (Random.Range(0, 100) == 0)
        {
            GameObject test = (GameObject)Instantiate(mario, new Vector3(Random.Range(0, 13), Random.Range(0, -4), -1), Quaternion.identity);
            test.GetComponent<mario_handler>().isClone = true;
            left_marios++;
        }/*
        else
        {
            GameObject test = (GameObject)Instantiate(bigMario, new Vector3(Random.Range(0, 10), Random.Range(-10, 10), -1), Quaternion.identity);
            test.GetComponent<bigMario_handler>().isClone = true;
        }*/
    }
}
