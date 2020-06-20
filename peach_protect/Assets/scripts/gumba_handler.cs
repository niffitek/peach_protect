using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gumba_handler : MonoBehaviour
{
    public float pos_x;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= pos_x)
        {
            Vector3 pos_new = transform.position;
            pos_new.x += 0.01f;
            transform.position = pos_new;
        }
        else
            anim.speed = 0;
    }
}
