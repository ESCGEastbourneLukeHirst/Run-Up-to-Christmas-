using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{

    Color col;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        col = GetComponent<Image>().color;
        col.a = 0;  // image alpha = 0 - image off
        col.a = 31;  // image alpha = 31 - image on
        GetComponent<Image>().color = col;

    }

}
