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
<<<<<<< HEAD

        if(Input.GetKey(KeyCode.W))
=======
        
        if (Input.GetKey(KeyCode.W) && transform.position.y <= 0)
>>>>>>> 7622c747c0f21556615fd9ef862a918e061ca8a9
        {
            anim.speed = 1;
            moveVec.y += movSpeed;
        }
<<<<<<< HEAD
        else if(Input.GetKey(KeyCode.A))
=======
        if (Input.GetKey(KeyCode.A) && transform.position.x >= -11)
>>>>>>> 7622c747c0f21556615fd9ef862a918e061ca8a9
        {
            anim.speed = 1; 
            moveVec.x -= movSpeed;
        }
<<<<<<< HEAD
        else if(Input.GetKey(KeyCode.S))
=======
        if (Input.GetKey(KeyCode.S) && transform.position.y >= -3)
>>>>>>> 7622c747c0f21556615fd9ef862a918e061ca8a9
        {
            anim.speed = 1; 
            moveVec.y -= movSpeed;
        }
<<<<<<< HEAD
        else if (Input.GetKey(KeyCode.D))
=======
        if (Input.GetKey(KeyCode.D) && transform.position.x <= 11)
>>>>>>> 7622c747c0f21556615fd9ef862a918e061ca8a9
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
