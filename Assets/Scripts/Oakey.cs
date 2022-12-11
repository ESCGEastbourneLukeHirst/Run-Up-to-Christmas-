using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oakey : MonoBehaviour
{
    public AudioSource Together;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            Together.Play();
        }
    }
}