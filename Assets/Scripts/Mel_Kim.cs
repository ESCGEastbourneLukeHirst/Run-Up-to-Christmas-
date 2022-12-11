using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mel_Kim : MonoBehaviour
{
    public AudioSource Respectable;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.N))
        {
            Respectable.Play();
        }
    }
}