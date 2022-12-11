using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheatham : MonoBehaviour
{
    public AudioSource Night;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            Night.Play();
            print("Have Get Down Saturday Night by Oliver Cheatham");
        }
    }
}