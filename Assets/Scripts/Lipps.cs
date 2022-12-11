using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lipps : MonoBehaviour
{
    public AudioSource Funkytown;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Funkytown.Play();
            print("Have Lipps Inc. - Funkytown");
        }
    }
}