using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeTextScript : MonoBehaviour
{
    Text FadeFade;
    // Start is called before the first frame update
    void Start()
    {
        FadeFade = GetComponent<Text>();
        FadeFade.enabled = true;
        FadeFade.color = new Color(0, 0, 0, 0f);
        Invoke("Color",3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Color()
    {
        FadeFade.color = new Color(0, 0, 0, 255f);
    }
}
