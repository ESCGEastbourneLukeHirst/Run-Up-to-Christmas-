using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Womack : MonoBehaviour
{
    public AudioSource Teardrops;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Teardrops.Play();
            print("Have Teardrops by Womack & Womack");
        }
    }
}

