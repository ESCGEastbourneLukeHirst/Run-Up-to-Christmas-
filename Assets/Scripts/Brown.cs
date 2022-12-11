using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brown : MonoBehaviour
{
    public AudioSource Preogrative;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            Preogrative.Play();
            print("Have My Preogrative by Bobby Brown");
        }
    }
}