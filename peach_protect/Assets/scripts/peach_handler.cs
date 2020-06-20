using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class peach_handler : MonoBehaviour
{
    private bool move = false;
    private float movSpeed = 0.02f;
    public int hp = 30;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = new Vector3(Random.Range(-10, -8), Random.Range(-4, 0), 0);
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
            SceneManager.LoadScene(2);
        Vector3 moveVec;
        if (Random.Range(0, 70) == 1)
        {
            if (move == true)
                move = false;
            else
                move = true;
        }
        if (transform.position.y >= 0)
            move = true;
        if (transform.position.y < -3)
            move = false;
        if (move == true)
        {
            moveVec = new Vector3(transform.position.x, transform.position.y - movSpeed, transform.position.y);
        }
        else
        {
            moveVec = new Vector3(transform.position.x, transform.position.y + movSpeed, transform.position.y);
        }
        transform.position = moveVec;
    }
}
