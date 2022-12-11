using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    // The red "X" sprite
    public Sprite redXSprite;

    // The Image component that will display the red "X"
    public Image redXImage;

    // Start is called before the first frame update
    void Start()
    {
        // Make sure the red "X" image is not visible by default
        redXImage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Set the red "X" sprite as the image
            redXImage.sprite = redXSprite;

            // Make the red "X" image visible
            redXImage.enabled = true;
        }
    }
}

