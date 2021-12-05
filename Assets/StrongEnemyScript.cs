using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StrongEnemyScript : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent agent;
    public GameObject EnemyArrow1;
    public GameObject EnemyArrow2;
    public GameObject EnemyArrow3;
    //public GameObject EnemyArrow2;
    //public GameObject EnemyArrow3;
    [SerializeField]
    private float ArrowSpeed = 1250;
    Vector3 force;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("kinositakariudo");
        agent = GetComponent<NavMeshAgent>();
        InvokeRepeating("ArrowAttack", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;
        /////// Arrow(EnemyArrow1, ArrowSpeed,new Vector3(0,3,0),0);
        ArrowAttack();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "kariudonoya")
        {
            CreateEnemyScript.numberofenemy--;
            CountEnemyScript.CountEnemy++;
            Destroy(this.gameObject);
        }
    }
    void ArrowAttack()
    {
        GameObject EnemyArrows1 = Instantiate(EnemyArrow1);
        GameObject EnemyArrows2 = Instantiate(EnemyArrow2);
        GameObject EnemyArrows3 = Instantiate(EnemyArrow3);

        //EnemyArrows2.transform.rotation = Quaternion.Euler(0, 20, 0);
        //EnemyArrows2.transform.position = this.transform.position + new Vector3(5, 3, 0);
        //force = this.gameObject.transform.forward * ArrowSpeed;
        //EnemyArrows2.GetComponent<Rigidbody>().AddForce(force);
        //Destroy(EnemyArrows2.gameObject, 4);
        Arrow(EnemyArrow1, ArrowSpeed, new Vector3(0, 3, 0), 0);
        Arrow(EnemyArrow2, ArrowSpeed, new Vector3(5, 3, 0), 20);
        Arrow(EnemyArrow3, ArrowSpeed, new Vector3(-5, 3, 0), -20);
    }
    void Arrow(GameObject DIY, float Speed, Vector3 Position, float Rotate)
    {
        DIY.transform.position = this.transform.position + Position;
        DIY.transform.rotation = Quaternion.Euler(0, Rotate, 0);
        force = this.gameObject.transform.forward * Speed;
        DIY.GetComponent<Rigidbody>().AddForce(force);
        Destroy(DIY.gameObject, 4);
    }   
}