using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowser_handler : MonoBehaviour
{
    public GameObject go;
    private float movSpeed = 0.03f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveVec = new Vector3(transform.position.x, transform.position.y, transform.position.y);
        if (Input.GetKey(KeyCode.W) && transform.position.y <= 0)
        {
            moveVec.y += movSpeed;
        }
        if (Input.GetKey(KeyCode.A) && transform.position.x >= -11)
        {
            moveVec.x -= movSpeed;
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y >= -3)
        {
            moveVec.y -= movSpeed;
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x <= 11)
        {
            moveVec.x += movSpeed;
        }
        if (Input.GetMouseButtonDown(0))
        {
            var v3 = Input.mousePosition;
            v3.z = 10.0f;
            v3 = Camera.main.ScreenToWorldPoint(v3);
            var x = v3.x;
            v3.x = -11f;
            GameObject test = (GameObject)Instantiate(go, v3, Quaternion.identity);
            test.GetComponent<gumba_handler>().pos_x = x;
        }
        transform.position = moveVec;
    }
}
