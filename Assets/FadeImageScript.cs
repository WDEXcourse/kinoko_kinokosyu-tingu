using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeImageScript : MonoBehaviour
{
    Image Fade;
    // Start is called before the first frame update
    void Start()
    {
        Fade = GetComponent<Image>();
        Fade.enabled = true;
        Fade.color = new Color(0, 0, 0,0f);
        Invoke("Color", 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Color()
    {
        Fade.color = new Color(255, 255, 255, 255f);
    }
}
