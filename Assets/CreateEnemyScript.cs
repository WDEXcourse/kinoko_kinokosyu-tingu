using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemyScript : MonoBehaviour
{
    public static int numberofenemy;
    public GameObject enemy;
    public GameObject strongenemy;
    public GameObject boss; 
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
            Debug.Log(numberofenemy);
            CountPhaseScript.CountPhase++;
            enemycreat();
        }
    }
    void enemycreat()
    {
        if (StartButtonHardScript.Degreeofdifficulty == 1)
        {
            if (CountPhaseScript.CountPhase%10 ==0 && CountPhaseScript.CountPhase >= 1)
            {
                for (int x = 0; x < 8; x++)
                {
                    Instantiate(strongenemy, new Vector3(Random.Range(-25, 51), 24, Random.Range(-51, 210)), Quaternion.identity);
                    numberofenemy++;
                }
                for (int x = 0; x < 2; x++)
                {
                    Instantiate(boss, new Vector3(Random.Range(-25, 51), 24, Random.Range(-51, 210)), Quaternion.identity);
                    numberofenemy++;
                }
            }
            else
            {
                if (CountPhaseScript.CountPhase % 3 == 0 && CountPhaseScript.CountPhase >= 1)
                {
                    for (int x = 0; x < 7; x++)
                    {
                        Instantiate(enemy, new Vector3(Random.Range(-25, 51), 24, Random.Range(-51, 210)), Quaternion.identity);
                        numberofenemy++;
                    }
                    for (int x = 0; x < 3; x++)
                    {
                        Instantiate(strongenemy, new Vector3(Random.Range(-25, 51), 24, Random.Range(-51, 210)), Quaternion.identity);
                        numberofenemy++;
                    }
                }
                else
                {
                    for (int x = 0; x < 10; x++)
                    {
                        Instantiate(enemy, new Vector3(Random.Range(-25, 51), 24, Random.Range(-51, 210)), Quaternion.identity);
                        numberofenemy++;
                    }
                }
            }

        }
        if (StartButtonHardScript.Degreeofdifficulty == 0)
        {
            //PlayerArrowScript.arrow--;
            for (int x = 0; x < 5; x++)
            {
                Instantiate(enemy, new Vector3(Random.Range(-25, 51), 24, Random.Range(-51, 210)), Quaternion.identity);
                numberofenemy++;
            }
            //PlayerArrowScript.arrow++;
        }
    }
     void strongenemycreat ()
    {

    }
}
