using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowser_handler : MonoBehaviour
{
    private float movSpeed = 0.03f;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveVec = new Vector3(transform.position.x, transform.position.y, -2);

        if(Input.GetKey(KeyCode.W))
        {
            anim.speed = 1;
            moveVec.y += movSpeed;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            anim.speed = 1; 
            moveVec.x -= movSpeed;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            anim.speed = 1; 
            moveVec.y -= movSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.speed = 1; 
            moveVec.x += movSpeed;
        }
        else
        {
            anim.speed = 0;
        }
        transform.position = moveVec;
    }
}
