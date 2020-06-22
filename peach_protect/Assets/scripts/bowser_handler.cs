using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class bowser_handler : MonoBehaviour
{
    public GameObject gumba;
    public GameObject shot;
    public GameObject spawner;
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
        Vector3 moveVec = new Vector3(transform.position.x, transform.position.y, transform.position.y);
        if (Input.GetKey(KeyCode.W) && transform.position.y <= 0)
        {
            moveVec.y += movSpeed;
            anim.speed = 1;
        }
        else if (Input.GetKey(KeyCode.A) && transform.position.x >= -11)
        {
            moveVec.x -= movSpeed;
            anim.speed = 1;
        }
        else if (Input.GetKey(KeyCode.S) && transform.position.y >= -3)
        {
            moveVec.y -= movSpeed;
            anim.speed = 1;
        }
        else if (Input.GetKey(KeyCode.D) && transform.position.x <= 11)
        {
            moveVec.x += movSpeed;
            anim.speed = 1;
        }
        else
            anim.speed = 0;
        if (Input.GetMouseButtonDown(1))
        {
            if (FindObjectOfType<MarioSpawner>().goombas > 0)
            {
                Vector3 pos = Input.mousePosition;
                pos.z = 10.0f;
                pos = Camera.main.ScreenToWorldPoint(pos);
                var x = pos.x;
                pos.x = -11;
                GameObject test = (GameObject)Instantiate(gumba, pos, Quaternion.identity);
                test.GetComponent<gumba_handler>().pos_x = x;
                test.GetComponent<gumba_handler>().isClone = true;
                test.GetComponent<gumba_handler>().begin = spawner.GetComponent<MarioSpawner>().welle;
                FindObjectOfType<MarioSpawner>().goombas--;
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = transform.position;
            pos.x += 1;
            GameObject test = (GameObject)Instantiate(shot, pos, Quaternion.identity);
            test.GetComponent<projectile>().isClone = true;
        }
        transform.position = moveVec;
    }
}
