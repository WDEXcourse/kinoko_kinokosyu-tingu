using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountEnemyScript : MonoBehaviour
{
    public static int CountEnemy;
    public Text EnemyText;

    // Start is called before the first frame update
    void Start()
    {
        CountEnemy = 0;
    }

    // Update is called once per frame
    void Update()
    {
        EnemyText.text = "Enemy" + CountEnemy.ToString();
    }
}
