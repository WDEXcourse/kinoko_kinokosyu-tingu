using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeTextScript2 : MonoBehaviour
{
    Text FadeFade2;
    public float Red;
    public float Green;
    public float Blue;
    // Start is called before the first frame update
    void Start()
    {
        Red = 61f / 255f;
        Green = 224f / 255f;
        Blue = 172f / 255f;
        FadeFade2 = GetComponent<Text>();
        FadeFade2.enabled = true;
        FadeFade2.color = new Color(61, 224, 172, 0f);
        Invoke("Color", 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Color()
    {
        FadeFade2.color = new Color(Red, Green, Blue, 1f);
        Debug.Log(Red);
        Debug.Log(Green);
        Debug.Log(Blue);
        Debug.Log(61f / 255f);
        //FadeFade2.color = new Color(56, 204, 157, 255f);
    }
}
