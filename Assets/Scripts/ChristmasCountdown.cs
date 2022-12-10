using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChristmasCountdown : MonoBehaviour
{
    Image img;

    AudioSource audio;
    public Color Color { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Color = new Color(img.color.r, img.color.g, img.color.b, img.color.a);
            print("On This Day, you received...");
            audio.Play();
        }
    }
}
