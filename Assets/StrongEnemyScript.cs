using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StrongEnemyScript : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent agent;
    public GameObject EnemyArrow;
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
        //for (int i = 0; i <= 2; i++) 
        //{
        //    float angle = transform.rotation.y;
        //    angle += 20;
        //    transform.rotation = Quaternion.Euler(0, angle, 0);
        //}
        GameObject EnemyArrows1 = Instantiate(EnemyArrow, transform.position, transform.rotation);
        GameObject EnemyArrows2 = Instantiate(EnemyArrow, transform.position, transform.rotation);
        EnemyArrows1.transform.position = this.transform.position + new Vector3(0, 3, 0);
        force = this.gameObject.transform.forward * ArrowSpeed;
        EnemyArrows1.GetComponent<Rigidbody>().AddForce(force);
        Destroy(EnemyArrows1.gameObject, 4);

    }
}
