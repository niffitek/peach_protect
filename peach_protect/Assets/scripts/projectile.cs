using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public bool isClone = false;
    public bool isColliding = false;
    void Update()
    {
        if (isClone == false)
            return;
        Vector3 moveVec = new Vector3(transform.position.x + 0.05f, transform.position.y, transform.position.y);
        transform.position = moveVec;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isColliding) return;
        isColliding = true;
        if (collision.gameObject.tag == "Mario")
        {
            collision.GetComponent<mario_handler>().life -= 1;
            Destroy(this.gameObject);
        }
    }
}
