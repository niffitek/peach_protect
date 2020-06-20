using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowser_handler : MonoBehaviour
{
    private float movSpeed = 0.03f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveVec = new Vector3(transform.position.x, transform.position.y, -2);
        
        if (Input.GetKey(KeyCode.W))
        {
            moveVec.y += movSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveVec.x -= movSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveVec.y -= movSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveVec.x += movSpeed;
        }
        transform.position = moveVec;
    }
}
