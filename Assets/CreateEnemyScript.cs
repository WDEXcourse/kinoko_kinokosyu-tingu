using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemyScript : MonoBehaviour
{
    public static int numberofenemy;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        numberofenemy = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (numberofenemy == 0)
        {
            enemycreat();
        }
    }
    void enemycreat()
    {
        //PlayerArrowScript.arrow--;
        for (int x = 0; x < 5; x++)
        {
            Instantiate(enemy, new Vector3(Random.Range(-25, 51), 24, Random.Range(-51, 210)), Quaternion.identity);
            numberofenemy++;
        }
        CountPhaseScript.CountPhase++;
        //PlayerArrowScript.arrow++;

    }
     void strongenemycreat ()
    {

    }
}
