using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABC : MonoBehaviour
{
    public AudioSource TheLookOfLove;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            TheLookOfLove.Play();
            print("Have The Look Of Love by ABC");
        }
    }
}
