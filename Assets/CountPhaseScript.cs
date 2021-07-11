using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountPhaseScript : MonoBehaviour
{
    public static int CountPhase;
    public Text PhaseText;

    // Start is called before the first frame update
    void Start()
    {
        CountPhase = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PhaseText.text = "Phase " + CountPhase.ToString();
    }
}
