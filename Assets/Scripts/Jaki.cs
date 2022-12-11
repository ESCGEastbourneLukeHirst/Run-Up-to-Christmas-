using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jaki : MonoBehaviour
{
    public AudioSource Love;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Y))
        {
            Love.Play();
            print("Have Could It Be I'm Falling In Love by Jaki Graham and David Stewart");
        }
    }
}