using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mario_handler : MonoBehaviour
{
    private float movSpeed = 0.01f;
    public bool isClone = false;
    private int life = 2;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (life == 1)
            anim.SetBool("small", true);
        if (life <= 0)
        {
            Destroy(this);
            return;
        }
        if (isClone == false)
            return;
        Vector3 moveVec = new Vector3(transform.position.x - movSpeed, transform.position.y, -2);
        transform.position = moveVec;
    }
}
