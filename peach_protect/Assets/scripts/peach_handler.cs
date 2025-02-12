﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class peach_handler : MonoBehaviour
{
    private bool move = false;
    private float movSpeed = 0.04f;
    public float lifebar = 50;
    public Image bar;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = new Vector3(-6, Random.Range(-4, 0), 0);
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveVec;
        if (lifebar <= 0)
            SceneManager.LoadScene(2);
        if (Random.Range(0, 70) == 1)
        {
            if (move == true)
                move = false;
            else
                move = true;
        }
        if (transform.position.y >= 0)
            move = true;
        if (transform.position.y < -3)
            move = false;

        if (move == true)
        {
            moveVec = new Vector3(transform.position.x, transform.position.y - movSpeed, transform.position.y);
        }
        else
        {
            moveVec = new Vector3(transform.position.x, transform.position.y + movSpeed, transform.position.y);
        }
        var theBarRectTransform = bar.transform as RectTransform;
        theBarRectTransform.sizeDelta = new Vector2(lifebar * 17.32f, theBarRectTransform.sizeDelta.y);
        transform.position = moveVec;
    }
}
