using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public bool isClone = false;
    void Update()
    {
        if (isClone == false)
            return;
        Vector3 moveVec = new Vector3(transform.position.x + 0.05f, transform.position.y, transform.position.y);
        transform.position = moveVec;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Mario")
        {
            collision.GetComponent<mario_handler>().lifebar -= 100;
            Destroy(gameObject);
        }
    }
}
