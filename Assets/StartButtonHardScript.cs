using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonHardScript : MonoBehaviour
{
    public static int Degreeofdifficulty;
    // Start is called before the first frame update
    void Start()
    {
        Degreeofdifficulty = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickStartButton()
    {
        Degreeofdifficulty = 1;
        SceneManager.LoadScene("kinositasyu-tingu");
    }
}
