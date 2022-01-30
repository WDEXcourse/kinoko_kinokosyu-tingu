using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossEnemyObject : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent agent;
    public GameObject EnemyArrowa;
    public GameObject EnemyArrowb;
    public GameObject EnemyArrowc;
    public GameObject EnemyArrowd;
    public GameObject EnemyArrowe;
    public GameObject EnemyArrowf;
    public GameObject EnemyArrowg;
    public GameObject EnemyArrowh;
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
        GameObject EnemyArrow1 = Instantiate(EnemyArrowa);
        GameObject EnemyArrow2 = Instantiate(EnemyArrowb);
        GameObject EnemyArrow3 = Instantiate(EnemyArrowc);
        GameObject EnemyArrow4 = Instantiate(EnemyArrowd);
        GameObject EnemyArrow5 = Instantiate(EnemyArrowe);
        GameObject EnemyArrow6 = Instantiate(EnemyArrowf);
        GameObject EnemyArrow7 = Instantiate(EnemyArrowg);
        GameObject EnemyArrow8 = Instantiate(EnemyArrowh);

        //EnemyArrows2.transform.rotation = Quaternion.Euler(0, 20, 0);
        //EnemyArrows2.transform.position = this.transform.position + new Vector3(5, 3, 0);
        //force = this.gameObject.transform.forward * ArrowSpeed;
        //EnemyArrows2.GetComponent<Rigidbody>().AddForce(force);
        //Destroy(EnemyArrows2.gameObject, 4);
        Arrow(EnemyArrow1, ArrowSpeed, new Vector3(0, 3, 4), 0);
        Arrow(EnemyArrow2, ArrowSpeed, new Vector3(3, 3, 3), 45);
        Arrow(EnemyArrow3, ArrowSpeed, new Vector3(4, 3, 0), 90);
        Arrow(EnemyArrow4, ArrowSpeed, new Vector3(3, 3, -3), 135);
        Arrow(EnemyArrow5, ArrowSpeed, new Vector3(0, 3, -4), 180);
        Arrow(EnemyArrow6, ArrowSpeed, new Vector3(-3, 3, -3), 225);
        Arrow(EnemyArrow7, ArrowSpeed, new Vector3(-4, 3, 0), 270);
        Arrow(EnemyArrow8, ArrowSpeed, new Vector3(-3, 3, 3), 315);
    }
    void Arrow(GameObject DIY, float Speed, Vector3 Position, float Rotate)
    {
        DIY.transform.position = this.transform.position + Position;
        DIY.transform.rotation = Quaternion.Euler(0, Rotate, 0);
        force = DIY.gameObject.transform.forward * Speed;
        DIY.GetComponent<Rigidbody>().AddForce(force);
        Destroy(DIY.gameObject, 4);
    }
}
