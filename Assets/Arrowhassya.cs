using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrowhassya : MonoBehaviour
{
    public GameObject EnemyArrowMissile;
    public int WayNumber;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0;i < WayNumber;i ++)
        {
            GameObject EnemyArrowFire = Instantiate(EnemyArrowMissile, transform.position, Quaternion.Euler(0, -30 + (15 * i), 0));
            EnemyArrowMissile.transform.SetParent(this.gameObject.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
