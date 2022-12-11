using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yazz : MonoBehaviour
{
    public AudioSource Up;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            Up.Play();
        }
    }
}