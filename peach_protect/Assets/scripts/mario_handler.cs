using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mario_handler : MonoBehaviour
{
    public float movSpeed = 0.04f;
    public bool isClone = false;
    public int life = 2;
    public int lifebar = 100;
    private float timer = 0.0f;
    private Animator anim;
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        lifebar = life * 100;
        anim = GetComponent<Animator>();
    }
    public float getTimer()
    {
        return timer;
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (isClone == false)
            return;
        if (life == 1)
            anim.SetBool("small", true);
        if (timer < 1)
            return;
        if (life <= 0 || transform.position.x <= -12)
        {
            spawner.GetComponent<MarioSpawner>().oneLess();
            Destroy(gameObject);
            return;
        }
        Vector3 moveVec = new Vector3(transform.position.x - movSpeed, transform.position.y, transform.position.y);
        transform.position = moveVec;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Peach")
        {
            collision.GetComponent<peach_handler>().lifebar -= life;
            spawner.GetComponent<MarioSpawner>().oneLess();
            Destroy(gameObject);
        }
    }
}
