using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseEnds : MonoBehaviour
{
    public AudioSource String;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.U))
        {
            String.Play();
            print("Have Hangin' on a String - Loose Ends");
        }
    }
}
