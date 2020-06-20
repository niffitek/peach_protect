using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gumba_handler : MonoBehaviour
{
    public GameObject Spawner;
    public int begin;
    public float pos_x;
    private Animator anim;
    public bool isClone = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isClone == false)
            return;
        if (Spawner.GetComponent<MarioSpawner>().welle != begin) {
            Vector3 pos_new = transform.position;
            pos_new.x -= 0.02f;
            transform.position = pos_new;
            return;
        }
        if (transform.position.x < -13)
        {
            Destroy(gameObject);
            return;
        }
        if (transform.position.x <= pos_x)
        {
            Vector3 pos_new = transform.position;
            pos_new.x += 0.01f;
            transform.position = pos_new;
        }
        else
            anim.speed = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Mario")
        {
            if (collision.gameObject.GetComponent<mario_handler>().life == 2)
                collision.gameObject.GetComponent<mario_handler>().life = 1;
            else
                collision.gameObject.GetComponent<mario_handler>().movSpeed = 0.005f;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Mario")
        {
            collision.gameObject.GetComponent<mario_handler>().movSpeed = 0.01f;
        }
    }
}
