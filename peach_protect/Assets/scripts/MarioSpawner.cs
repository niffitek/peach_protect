using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MarioSpawner : MonoBehaviour
{
    public GameObject mario;
    public GameObject bowserSpawn;

    //  public GameObject bigMario;
    private float sleeper = 1.0f;
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
            bowserSpawn.GetComponent<bowser_handler>().leftgumba++;
            for (int i = 0; i < welle * 3; i++)
            {
                Spawner();
            }
        }
    }

    void Spawner()
    {
        GameObject test = (GameObject)Instantiate(mario, new Vector3(Random.Range(0, 13), Random.Range(0, -4), -1), Quaternion.identity);
        test.GetComponent<mario_handler>().isClone = true;
        left_marios++;
        if (Random.Range(0, 2) == 0)
        {
            test.GetComponent<mario_handler>().life = 1;
        }
    }
    public void oneLess()
    {
        left_marios--;
    }
}
