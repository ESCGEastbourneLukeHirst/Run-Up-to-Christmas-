using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChristmasCountdown : MonoBehaviour
{
    Color col;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Image>().color;
        GetComponent<Image>().color = col;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // checks the date
            DateTime currentDate = DateTime.Today;
            if (currentDate != DateTime.Today)
            {
                print("You cannot open this door yet");
            }
            col.a = 0;  // image alpha = 0 - image off
            col.a = 31;  // image alpha = 31 - image on   
        }

        

    }

}
