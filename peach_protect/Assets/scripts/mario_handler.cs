using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mario_handler : MonoBehaviour
{
    private float movSpeed = 0.01f;
    public bool isClone = false;
    private int life = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isClone == false)
            return;

        if (life <= 0 || transform.position.x <= -12)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 moveVec = new Vector3(transform.position.x - movSpeed, transform.position.y, transform.position.y);
        transform.position = moveVec;
    }
}
