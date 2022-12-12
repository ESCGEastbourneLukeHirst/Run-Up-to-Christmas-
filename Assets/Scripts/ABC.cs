using System;
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
            // check to see if it's the correct date
            DateTime currentDate = DateTime.Today;
            string dateString = currentDate.ToString("MM/dd/yyyy");
            if (currentDate != DateTime.Today)
            {
                print("It's not that day yet!");
            }
            else
            {
                TheLookOfLove.Play();
                print("Have The Look Of Love by ABC");
            }
        }
    }
}
