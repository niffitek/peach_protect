using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ui_handler : MonoBehaviour
{
    public TMP_Text wave;
    public TMP_Text goombas;

    // Update is called once per frame
    void Update()
    { 
        wave.text = FindObjectOfType<MarioSpawner>().welle.ToString();
        goombas.text = FindObjectOfType<MarioSpawner>().goombas.ToString();
    }
}
